<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Domain.Model.Category>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%using (Html.BeginForm())
      {%>
    Enter name to search for: <input type="text" value="" name="name" />
    <input type="submit" value="Find" />
    <%} %>
    <ul>
        <%foreach (var item in Model)
          { %>
        <li>
            <%:item.Name %></li>
        <%} %>
    </ul>
</body>
</html>
