<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="AspProject.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% AspProject.Tutorial tp=new AspProject.Tutorial();%>

		<%=tp.Name%>
           <br /> 
            <%=tp.m_customerName%>
            <br />
            <%=tp.m_balance%>

        </div>
    </form>
</body>
</html>
