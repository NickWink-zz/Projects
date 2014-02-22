<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseFaculty.aspx.cs" Inherits="Contact_List.CourseFaculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Faculty List</title>
    <link href="style.css" type="text/css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="wrapper">
        <br />
    <fieldset id="form"> 
        <legend>Add a new Course Faculty Record</legend>
            <asp:Label ID="LabelMeid" runat="server" Text="MEID: " CssClass="label"></asp:Label>&nbsp;<asp:TextBox ID="TextBoxMeid" runat="server" CssClass="textbox"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxFirstName" ErrorMessage="Required Field"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelFirstName" runat="server" Text="First Name: " CssClass="label"></asp:Label>&nbsp;<asp:TextBox ID="TextBoxFirstName" runat="server" CssClass="textbox"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxLastName" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelLastName" runat="server" Text="Last Name: " CssClass="label"></asp:Label>&nbsp;<asp:TextBox ID="TextBoxLastName" runat="server" CssClass="textbox"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxMajor" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelMajorID" runat="server" Text="Major ID: " CssClass="label"></asp:Label>&nbsp;<asp:TextBox ID="TextBoxMajor" runat="server" CssClass="textbox"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxMeid" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="LabelEmail" runat="server" Text="Email Address: " CssClass="label"></asp:Label>&nbsp;<asp:TextBox ID="TextBoxEmail" runat="server" CssClass="textbox"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit Record" CssClass="button" OnClick="ButtonSubmit_Click" />
         </fieldset>
    </div>
    </form>
</body>
</html>
