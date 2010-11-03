<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Domain.Model.Category>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />
    <title>
        <%:Model.Name %></title>
</head>
<body>
    You selected the Category '<%:Model.Name %>', with Id '<%:Model.Id %>'.
    <%=Html.ActionLink("<< Back to Selection", "Index") %>
</body>
</html>
