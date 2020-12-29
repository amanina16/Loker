<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Lantai.aspx.cs" Inherits="Lantai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h4>LOKASI LOKER</h4>
        <asp:Label ID="lbl" runat="server">Masukkan no Loker</asp:Label><br />
        <asp:TextBox ID="txtloker" runat="server" onkeypress="return IsNumeric(event);"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"
          onclick="btnSubmit_Click" />
    
    </div>
    </form>

    <div id="dvlokasi" runat="server">
        <h4> <asp:Label ID="lbllokasi" runat="server"></asp:Label><br /></h4>
    </div>
</body>
</html>

 <script type="text/javascript">  
  
     function IsNumeric(evt)
        {  
            evt = (evt) ? evt : window.event;
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 32 && (charCode < 48 || charCode > 57)) {
                return false;
            }
            return true;
        }  
    </script>  
