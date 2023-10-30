<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Validation.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form Validation</title>
</head>
<body>
    <h1>Please Enter your details</h1>
    <form id="form1" runat="server">
        
    <label for="name">Name : 
        <asp:TextBox ID="TextBox8" runat="server" Width="157px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
        <br/>

    <label for="familyname">Family Name :&nbsp; </label>
        <asp:TextBox ID="famname" runat="server" Width="159px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br/>

    <label for="address">Address : 
        <asp:TextBox ID="TextBox3" runat="server" Width="451px"></asp:TextBox>
        </label>
    <oninput type="text" id="address" required>&nbsp;&nbsp;&nbsp;&nbsp; atleast 2 characters
        <asp:HiddenField ID="HiddenField2" runat="server" />
        <br/>

    <label for="city">City : 
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </label>
    <oninput type="text" id="city" required>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; atleast 2 characters
        <asp:HiddenField ID="HiddenField3" runat="server" />
        <br/>

    <label for="pincode">Zip Code :
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </label>
    <oninput type="text" id="zipCode" required>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br/>

    <label for="phoneno">Phone :&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </label>
    <oninput type="text" id="phone" required><br/>

    <label for="emailid">Email ID :
        <asp:TextBox ID="TextBox7" runat="server" Width="278px"></asp:TextBox>
        </label>
    <oninput type="email" id="email" required><br/>

        <br />

    <button type="button" onclick="validate_the_Input()" id="check">Check</button>

  <div id="final">
    <h2>Validation : </h2>
    <p id="Message">&nbsp;</p>
  </div>

  </form>

  <script>
    function validate_the_Input() {
      
      var name = document.getElementById("name").value;
      var family_name = document.getElementById("familyname").value;
      var address = document.getElementById("address").value;
      var city = document.getElementById("city").value;
      var pincode = document.getElementById("pincode").value;
      var phone = document.getElementById("phoneno").value;
      var email = document.getElementById("emailid").value;

          var namevalid = (name!=family_name);
          var addressvalid = address.length >= 2;
          var cityvalid = city.length >= 2;
          var pincodevalid = /^\d{5}$/.test(pincode);
          var phonenovalid = /^(\d{2}-\d{7}|\d{3}-\d{7})$/.test(phone);
          var emailvalid = /^[A-Za-z0-9._-]+@[A-Za-z0-9.-]+\.[A-Za-z]$/.test(email);

          var Result = " ";
          if (!namevalid) Result += "Name must be different from Family Name\n";
          if (!addressvalid) Result += "Address must have at least 2 letters\n";
          if (!cityvalid) Result += "City must have at least 2 letters\n";
          if (!pincodevalid) Result += "Zip Code must have 6 digits\n";
          if (!phonenovalid) Result += "Phone no must be in the format XX-XXXXXXX or XXX-XXXXXXX.\n";
          if (!emailvalid) Result += "Invalid Email Address.\n";

        if (Result == " ") {
            Result = "Validation done";
        }
        else {
            Result="Invalid"
        }

        document.getElementById("Message").innerText=Result
         document.getElementById("result");
    }
  </script>
</body>
</html>