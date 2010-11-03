<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<System.Collections.Generic.IEnumerable<Domain.Model.Category>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <table>
        <thead>
            <tr>
                <th>
                </th>
                <th>
                    Name
                </th>
            </tr>
        </thead>
        <tbody>
            <%foreach (var cat in Model) %>
            <%
                {%>
            <tr>
                <td>
                    <%=Html.ActionLink("Select", "View", new {id = cat.Id}) %>
                </td>
                <td>
                    <%:cat.Name %>
                </td>
            </tr>
            <%
                }%>
        </tbody>
    </table>
</body>
</html>
