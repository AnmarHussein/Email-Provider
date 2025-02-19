using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace ToolKit.Emails.Utilities;
public static class TemplateParser
{
    private static readonly Regex PlaceholderRegex = new Regex(@"###([A-Za-z0-9_]+)###" , RegexOptions.Compiled);
    private static readonly Regex TableStartRegex = new Regex(@"###\[TableStart:([A-Za-z0-9_]+)\]###" , RegexOptions.Compiled);
    private static readonly Regex TableEndRegex = new Regex(@"###\[TableEnd:([A-Za-z0-9_]+)\]###" , RegexOptions.Compiled);
    public static string ReplacePlaceholders(string template , object model)
    {
        if (model == null) return template;

        template = PlaceholderRegex.Replace(template , match =>
        {
            string propertyName = match.Groups[1].Value;
            var prop = model.GetType().GetProperty(propertyName);
            return prop?.GetValue(model)?.ToString() ?? match.Value;
        });

        template = ProcessDynamicTables(template , model);

        return template;
    }

    private static string ProcessDynamicTables(string template , object model)
    {
        var tableMatches = TableStartRegex.Matches(template);
        foreach (Match match in tableMatches)
        {
            string tableName = match.Groups[1].Value;
            string tableStart = match.Value;
            string tableEnd = $"###[TableEnd:{tableName}]###";

            int startIndex = template.IndexOf(tableStart);
            int endIndex = template.IndexOf(tableEnd);

            if (startIndex == -1 || endIndex == -1)
                continue;

            string tableTemplate = template.Substring(
                startIndex + tableStart.Length ,
                endIndex - (startIndex + tableStart.Length)
            );

            var tableData = model.GetType().GetProperty(tableName)?.GetValue(model) as IEnumerable;
            if (tableData == null)
                continue;

            var tableContent = new StringBuilder();
            foreach (var row in tableData)
            {
                string rowContent = tableTemplate;
                rowContent = PlaceholderRegex.Replace(rowContent , m =>
                {
                    string propertyName = m.Groups[1].Value;
                    var prop = row.GetType().GetProperty(propertyName);
                    return prop?.GetValue(row)?.ToString() ?? m.Value;
                });
                tableContent.Append(rowContent);
            }

            template = template.Remove(startIndex , endIndex + tableEnd.Length - startIndex)
                               .Insert(startIndex , tableContent.ToString());
        }

        return template;
    }
}
