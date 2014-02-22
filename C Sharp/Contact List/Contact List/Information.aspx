<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="Contact_List.ContactList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Department Chair list</title>
    <link href="style.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div  id="wrapper">
      <h1>Department Chair List </h1>
        <p>Please use the fields below to view current contact information for the Depart Chair.</p>
        
        <br />
        <div class="gridview">
            <asp:GridView ID="GridViewDirector" runat="server" Height="243px" Width="536px" AutoGenerateColumns="False" DataKeyNames="Major_ID" DataSourceID="SqlDataSource1" ShowHeaderWhenEmpty="True" AutoGenerateEditButton="True" AllowSorting="True" style="margin-bottom: 0px">
                <Columns>
                    <asp:BoundField DataField="Major_ID" HeaderText="Major_ID" ReadOnly="True" SortExpression="Major_ID" />
                    <asp:BoundField DataField="Department_Chair_Name" HeaderText="Department_Chair_Name" SortExpression="Department_Chair_Name" />
                    <asp:BoundField DataField="Major_Name" HeaderText="Major_Name" SortExpression="Major_Name" />
                    <asp:BoundField DataField="Phone_Number" HeaderText="Phone_Number" SortExpression="Phone_Number" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Major ID] AS Major_ID, [Department Chair Name] AS Department_Chair_Name, [Major Name] AS Major_Name, [Phone Number] AS Phone_Number, [Email] FROM [departmentChair]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [departmentChair] WHERE [Major ID] = @original_Major_ID AND [Department Chair Name] = @original_Department_Chair_Name AND [Major Name] = @original_Major_Name AND [Phone Number] = @original_Phone_Number AND [Email] = @original_Email" InsertCommand="INSERT INTO [departmentChair] ([Major ID], [Department Chair Name], [Major Name], [Phone Number], [Email]) VALUES (@Major_ID, @Department_Chair_Name, @Major_Name, @Phone_Number, @Email)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [departmentChair] SET [Department Chair Name] = @Department_Chair_Name, [Major Name] = @Major_Name, [Phone Number] = @Phone_Number, [Email] = @Email WHERE [Major ID] = @original_Major_ID AND [Department Chair Name] = @original_Department_Chair_Name AND [Major Name] = @original_Major_Name AND [Phone Number] = @original_Phone_Number AND [Email] = @original_Email">
                <DeleteParameters>
                    <asp:Parameter Name="original_Major_ID" Type="String" />
                    <asp:Parameter Name="original_Department_Chair_Name" Type="String" />
                    <asp:Parameter Name="original_Major_Name" Type="String" />
                    <asp:Parameter Name="original_Phone_Number" Type="String" />
                    <asp:Parameter Name="original_Email" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Major_ID" Type="String" />
                    <asp:Parameter Name="Department_Chair_Name" Type="String" />
                    <asp:Parameter Name="Major_Name" Type="String" />
                    <asp:Parameter Name="Phone_Number" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Department_Chair_Name" Type="String" />
                    <asp:Parameter Name="Major_Name" Type="String" />
                    <asp:Parameter Name="Phone_Number" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="original_Major_ID" Type="String" />
                    <asp:Parameter Name="original_Department_Chair_Name" Type="String" />
                    <asp:Parameter Name="original_Major_Name" Type="String" />
                    <asp:Parameter Name="original_Phone_Number" Type="String" />
                    <asp:Parameter Name="original_Email" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
        <br />
            <h1>Course Faculty List</h1>
            <p>Below is the Course faculty list.</p>
            <p>If you wish to add a record select add new record. You will be re-directed to a new page. </p> <br /> 
            <ul id="newrecord">
                <li><a id="btn" href="CourseFaculty.aspx">Add New Record</a></li>
            </ul>
            <br />
            <br />
       <div class="gridview">
                <asp:GridView ID="GridViewFaculty" runat="server" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateEditButton="True" DataKeyNames="MEID" DataSourceID="SqlDataSource2" Height="243px" Width="536px">
                    <Columns>
                        <asp:BoundField DataField="MEID" HeaderText="MEID" ReadOnly="True" SortExpression="MEID" />
                        <asp:BoundField DataField="First_Name" HeaderText="First_Name" SortExpression="First_Name" />
                        <asp:BoundField DataField="Major_ID" HeaderText="Major_ID" SortExpression="Major_ID" />
                        <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" SortExpression="Last_Name" />
                        <asp:BoundField DataField="Email_Address" HeaderText="Email_Address" SortExpression="Email_Address" />
                        <asp:BoundField DataField="Phone_Number" HeaderText="Phone_Number" SortExpression="Phone_Number" />
                    </Columns>
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [MEID], [First Name] AS First_Name, [Major ID] AS Major_ID, [Last Name] AS Last_Name, [Email Address] AS Email_Address, [Phone Number] AS Phone_Number FROM [CourseFaculty]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [CourseFaculty] WHERE [MEID] = @original_MEID AND [First Name] = @original_First_Name AND [Major ID] = @original_Major_ID AND [Last Name] = @original_Last_Name AND [Email Address] = @original_Email_Address AND [Phone Number] = @original_Phone_Number" InsertCommand="INSERT INTO [CourseFaculty] ([MEID], [First Name], [Major ID], [Last Name], [Email Address], [Phone Number]) VALUES (@MEID, @First_Name, @Major_ID, @Last_Name, @Email_Address, @Phone_Number)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [CourseFaculty] SET [First Name] = @First_Name, [Major ID] = @Major_ID, [Last Name] = @Last_Name, [Email Address] = @Email_Address, [Phone Number] = @Phone_Number WHERE [MEID] = @original_MEID AND [First Name] = @original_First_Name AND [Major ID] = @original_Major_ID AND [Last Name] = @original_Last_Name AND [Email Address] = @original_Email_Address AND [Phone Number] = @original_Phone_Number" >
                    <DeleteParameters>
                        <asp:Parameter Name="original_MEID" Type="String" />
                        <asp:Parameter Name="original_First_Name" Type="String" />
                        <asp:Parameter Name="original_Major_ID" Type="String" />
                        <asp:Parameter Name="original_Last_Name" Type="String" />
                        <asp:Parameter Name="original_Email_Address" Type="String" />
                        <asp:Parameter Name="original_Phone_Number" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="MEID" Type="String" />
                        <asp:Parameter Name="First_Name" Type="String" />
                        <asp:Parameter Name="Major_ID" Type="String" />
                        <asp:Parameter Name="Last_Name" Type="String" />
                        <asp:Parameter Name="Email_Address" Type="String" />
                        <asp:Parameter Name="Phone_Number" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="First_Name" Type="String" />
                        <asp:Parameter Name="Major_ID" Type="String" />
                        <asp:Parameter Name="Last_Name" Type="String" />
                        <asp:Parameter Name="Email_Address" Type="String" />
                        <asp:Parameter Name="Phone_Number" Type="String" />
                        <asp:Parameter Name="original_MEID" Type="String" />
                        <asp:Parameter Name="original_First_Name" Type="String" />
                        <asp:Parameter Name="original_Major_ID" Type="String" />
                        <asp:Parameter Name="original_Last_Name" Type="String" />
                        <asp:Parameter Name="original_Email_Address" Type="String" />
                        <asp:Parameter Name="original_Phone_Number" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>

        </div>
    </div>
    </form>
</body>
</html>
