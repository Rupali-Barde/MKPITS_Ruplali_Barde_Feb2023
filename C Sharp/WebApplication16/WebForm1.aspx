<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication16.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/javascript" language ="javascript">
        function alert_meth()
        {
            alert("Client Side MessageBox");

        }
        function confirm_meth()
        {
            if (confirm("Do You Want To Confirm 'YES'") == true) {
                document.writeln("<b> You had click on 'YES' button </b>");

            }
            else
            {
                document.writeln("<b> You had click on 'NO' button</b>");
            }

        }
        </script>

</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:Button OnClientClick="confirm_meth()" ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </p>
        <div>
            <asp:Button OnClientClick="alert_meth()"  ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

            <br/>
            <br/>
        </div>
    </form>
</body>
</html>
