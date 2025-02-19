namespace ToolKit.Emails.Utilities;

/// <summary>
///  This to only get fake data
/// </summary>
public static class HtmlTemplateProvider
{
    public static string NewslettersTemplate()
    {
        return """
            <!DOCTYPE html>
            <html lang="en">
            <head>
                <meta charset="UTF-8">
                <meta name="viewport" content="width=device-width, initial-scale=1.0">
                <title>Creative Email Template</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }
                    .email-container {
                        max-width: 600px;
                        margin: 0 auto;
                        background-color: #ffffff;
                        border-radius: 10px;
                        overflow: hidden;
                        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                    }
                    .header {
                        background-color: #4CAF50;
                        color: white;
                        padding: 20px;
                        text-align: center;
                    }
                    .header h1 {
                        margin: 0;
                        font-size: 24px;
                    }
                    .content {
                        padding: 20px;
                        color: #333333;
                    }
                    .content h2 {
                        font-size: 20px;
                        margin-bottom: 15px;
                    }
                    .content p {
                        font-size: 16px;
                        line-height: 1.6;
                    }
                    .cta-button {
                        display: inline-block;
                        background-color: #4CAF50;
                        color: white;
                        padding: 10px 20px;
                        text-decoration: none;
                        border-radius: 5px;
                        margin-top: 20px;
                    }
                    .footer {
                        background-color: #f1f1f1;
                        padding: 15px;
                        text-align: center;
                        font-size: 14px;
                        color: #666666;
                    }
                    .footer a {
                        color: #4CAF50;
                        text-decoration: none;
                    }
                    @media (max-width: 600px) {
                        .email-container {
                            width: 100%;
                        }
                        .header h1 {
                            font-size: 20px;
                        }
                        .content h2 {
                            font-size: 18px;
                        }
                        .content p {
                            font-size: 14px;
                        }
                        .cta-button {
                            font-size: 14px;
                        }
                    }
                </style>
            </head>
            <body>
                <div class="email-container">
                    <div class="header">
                        <h1>Welcome to Our Creative World!</h1>
                    </div>
                    <div class="content">
                        <h2>Hello ###FullName###</h2>
                        <p>We're thrilled to have you here! Whether you're looking for inspiration, the latest trends, or just a little something to brighten your day, we've got you covered.</p>
                        <p>Explore our new collection and discover what's waiting for you. Don't miss out on our exclusive offers and updates.</p>
                        <a href="###Link###" class="cta-button">###NameLink###</a>
                    </div>
                    <div class="footer">
                        <p>If you have any questions, feel free to <a href="#">contact us</a>.</p>
                        <p>You are receiving this email because you signed up for our newsletter. <a href="">Unsubscribe</a>.</p>
                    </div>
                </div>
            </body>
            </html>
            """;
    }

    public static string DynamicTableTemplate()
    {
        return """
            <!DOCTYPE html>
            <html lang="en">
            <head>
                <meta charset="UTF-8">
                <meta name="viewport" content="width=device-width, initial-scale=1.0">
                <title>Dynamic Table Email Template</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                    }
                    .email-container {
                        max-width: 600px;
                        margin: 0 auto;
                        background-color: #ffffff;
                        border-radius: 10px;
                        overflow: hidden;
                        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                    }
                    .header {
                        background-color: #4CAF50;
                        color: white;
                        padding: 20px;
                        text-align: center;
                    }
                    .header h1 {
                        margin: 0;
                        font-size: 24px;
                    }
                    .content {
                        padding: 20px;
                        color: #333333;
                    }
                    .content h2 {
                        font-size: 20px;
                        margin-bottom: 15px;
                    }
                    .content p {
                        font-size: 16px;
                        line-height: 1.6;
                    }
                    .cta-button {
                        display: inline-block;
                        background-color: #4CAF50;
                        color: white;
                        padding: 10px 20px;
                        text-decoration: none;
                        border-radius: 5px;
                        margin-top: 20px;
                    }
                    .table-container {
                        margin-top: 20px;
                        overflow-x: auto;
                    }
                    table {
                        width: 100%;
                        border-collapse: collapse;
                        margin-bottom: 20px;
                    }
                    table, th, td {
                        border: 1px solid #ddd;
                    }
                    th, td {
                        padding: 12px;
                        text-align: left;
                    }
                    th {
                        background-color: #f2f2f2;
                        color: #333;
                    }
                    tr:nth-child(even) {
                        background-color: #f9f9f9;
                    }
                    .footer {
                        background-color: #f1f1f1;
                        padding: 15px;
                        text-align: center;
                        font-size: 14px;
                        color: #666666;
                    }
                    .footer a {
                        color: #4CAF50;
                        text-decoration: none;
                    }
                    @media (max-width: 600px) {
                        .email-container {
                            width: 100%;
                        }
                        .header h1 {
                            font-size: 20px;
                        }
                        .content h2 {
                            font-size: 18px;
                        }
                        .content p {
                            font-size: 14px;
                        }
                        .cta-button {
                            font-size: 14px;
                        }
                        table, th, td {
                            font-size: 14px;
                            padding: 8px;
                        }
                    }
                </style>
            </head>
            <body>
                <div class="email-container">
                    <div class="header">
                        <h1>Your Monthly Report</h1>
                    </div>
                    <div class="content">
                        <h2>Hello ###FullName###,</h2>
                        <p>Here is your monthly report. Please find the details below:</p>
                        <div class="table-container">
                            <table>
                                <thead>
                                    <tr>
                                        <th>ProductName</th>
                                        <th>Quantity</th>
                                        <th>Change</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    ###[TableStart:Items]###
                                    <tr>
                                        <td>###ProductName###</td>
                                        <td>###Quantity###</td>
                                        <td>###Price###</td>
                                    </tr>
                                    ###[TableEnd:Items]###
                                </tbody>
                            </table>
                        </div>
                        <p>If you have any questions or need further details, feel free to reach out to us.</p>
                        <a href="###Link###" class="cta-button">###NameLink###</a>
                    </div>
                    <div class="footer">
                        <p>You are receiving this email because you signed up for our monthly reports. <a href="#">Unsubscribe</a>.</p>
                    </div>
                </div>
            </body>
            </html>
            """;
    }

}
