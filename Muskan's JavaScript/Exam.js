function validate_spid(spid,s1)
{
    if(spid.value=="")
    {
        s1.style.color= "red";
        s1.innerHTML="Enter SPID"
        return false
    }   
    else if(!/[0-9]{5,10}/g.test(spid.value)) 
    {
        s1.style.color= "red";
        s1.innerHTML="Enter SPID in Numbers and also its length should be more than 10 "
        return false
    }
    else
    {
        s1.style.color= "green";
        s1.innerHTML="Correct!"
        return true
    }
}
function validate_roll(roll,s2)
{
    if(roll.value=="")
    {
        s2.style.color= "red";
        s2.innerHTML="Enter Roll Number"
        return false
    } 
    else if(!/[0-9]{1,3}/.test(roll.value)) 
    {
        s2.style.color= "red";
        s2.innerHTML="Enter correct name with first letter capital "
        return false
    } 
    else
    {
        s2.style.color= "green";
        s2.innerHTML="Correct!"
        return true
    } 
}
function validate_nm(nm,s3)
{
    if(nm.value=="")
    {
        s3.style.color= "red";
        s3.innerHTML="Enter Name"
        return false
    } 
    else if(!/^[A-Z][a-z'-]+(?: [A-Z][a-z'-]+)*$/.test(nm.value))  ///^[A-Z]{1}[a-z]{1,}$/
    {
        s3.style.color= "red";
        s3.innerHTML="Enter correct name with first letter capital "
        return false
    } 
    else
    {
        s3.style.color= "green";
        s3.innerHTML="Correct!"
        return true
    } 
}
// function validate_nm(nm,s3)
// {
//     var patt=/^[A-Z]{1}[a-z]{1,}$/s
//     if(name.value=="")
//     {
//         s3.style.color="red";
//         s3.innerHTML="Enter Name";
//         return false;
//     }
//     else if(patt.test(name.value)==false)
//     {        
//         s3.style.color="red";
//         s3.innerHTML="First letter should be in uppercase";
//         return false;
//     }
//     else
//     {     
//         s3.style.color="green";
//         s3.innerHTML="Success";
//         return true;
//     }
// }
function validate_semester(semester,s4)
{
    if(semester.value=="")
    {
        s4.style.color= "red";
        s4.innerHTML="Enter Semester"
        return false
    } 
    else if(!/[0-9]{1,3}/.test(semester.value)) 
    {
        s4.style.color= "red";
        s4.innerHTML="Enter correct semester in number "
        return false
    } 
    else
    {
        s4.style.color= "green";
        s4.innerHTML="Correct!"
        return true
    } 
}
function validate_division(division,s5)
{
    if(division.value=="")
    {
        s5.style.color= "red";
        s5.innerHTML="Enter Division"
        return false
    } 
    else if(!/[A-Z]{1}/.test(division.value)) 
    {
        s5.style.color= "red";
        s5.innerHTML="Enter division in single capital letter "
        return false
    } 
    else
    {
        s5.style.color= "green";
        s5.innerHTML="Correct!"
        return true
    } 
}
function validate_age(age,s6)
{
    if(age.value=="")
    {
        s6.style.color= "red";
        s6.innerHTML="Enter Age"
        return false
    } 
    else if(!(parseInt(age.value)>=18))
    {
        s6.style.color= "red";
        s6.innerHTML="Enter correct age "
        return false
    } 
    else
    {
        s6.style.color= "green";
        s6.innerHTML="Correct!"
        return true
    } 
}
function validate_gender(gender,s7)
{
    if(gender[0].checked==false && gender[1].checked == false )
    {
        s7.style.color= "red";
        s7.innerHTML="Select Gender"
        return false
    } 
    else
    {
        s7.style.color= "green";
        s7.innerHTML="Correct!"
        return true
    } 
}
function validate_email(email,s8)
{
    if(email.value=="")
    {
        s8.style.color= "red";
        s8.innerHTML="Enter Email"
        return false
    } 
    else if(!/^[a-zA-Z0-9_\-.]+@[a-zA-Z0-9-.]+\.[a-zA-Z]{2,4}$/.test(email.value)) 
    {
        s8.style.color= "red";
        s8.innerHTML="Enter correct email "
        return false
    } 
    else
    {
        s8.style.color= "green";
        s8.innerHTML="Correct!"
        return true
    } 
}
function validate_mobile(mobile,s9)
{
    if(mobile.value=="")
    {
        s9.style.color= "red";
        s9.innerHTML="Enter Mobile Number"
        return false
    } 
    else if(!/^[0-9]{10}$/.test(mobile.value)) 
    {
        s9.style.color= "red";
        s9.innerHTML="Enter correct mobile number "
        return false
    } 
    else
    {
        s9.style.color= "green";
        s9.innerHTML="Correct!"
        return true
    } 
}
function validate_url(url,s10)
{
    if(url.value=="")
    {
        s10.style.color= "red";
        s10.innerHTML="Enter Linkedin URL"
        return false
    } 
    else if(!/^https:\/\/www\.linkedin\.com\/(?:in|pub)\/[a-zA-Z0-9_-]+$/.test(url.value)) 
    {
        s10.style.color= "red";
        s10.innerHTML="Enter correct URL "
        return false
    } 
    else
    {
        s10.style.color= "green";
        s10.innerHTML="Correct!"
        return true
    } 
}
function validate_username(username,s11)
{
    if(username.value=="")
    {
        s11.style.color= "red";
        s11.innerHTML="Enter Username"
        return false
    } 
    else if((username.value).length<=5) 
    {
        s11.style.color= "red";
        s11.innerHTML="Username should be more than 5 characters"
        return false
    } 
    else
    {
        s11.style.color= "green";
        s11.innerHTML="Correct!"
        return true
    } 
}
function validate_password(password,s12)
{
    if(password.value=="")
    {
        s12.style.color= "red";
        s12.innerHTML="Enter Password"
        return false
    } 
    else if(!/^[a-zA-Z0-9-_*@#$%&]{8,}$/.test(password.value)) 
    {
        s12.style.color= "red";
        s12.innerHTML="Password should contain atleast 8 characters"
        return false
    } 
    else
    {
        s12.style.color= "green";
        s12.innerHTML="Correct!"
        return true
    } 
}
function validate_confirm(password,con,s13)
{
    if(con.value=="")
    {
        s13.style.color= "red";
        s13.innerHTML="Enter Password again to confirm"
        return false
    } 
    else if(con.value!=password.value) 
    {
        s13.style.color= "red";
        s13.innerHTML="Password doesn't match with the original one"
        return false
    } 
    else
    {
        s13.style.color= "green";
        s13.innerHTML="Correct!"
        return true
    } 
}
function validate_language(language,s14)
{
    if(language[0].checked==false && language[1].checked == false && language[2].checked == false && language[3].checked == false)
    {
        s14.style.color= "red";
        s14.innerHTML="Select Atleast one programming language "
        return false
    } 
    else
    {
        s14.style.color= "green";
        s14.innerHTML="Correct!"
        return true
    } 
}
function validate_state(state,s15)
{
    if(state.value=="")
    {
        s15.style.color= "red";
        s15.innerHTML="Select state"
        return false
    } 
    else
    {
        s15.style.color= "green";
        s15.innerHTML="Correct!"
        return true
    } 
}
function validate_city(city,s16)
{
    if(city.value=="")
    {
        s16.style.color= "red";
        s16.innerHTML="Select city"
        return false
    } 
    else
    {
        s16.style.color= "green";
        s16.innerHTML="Correct!"
        return true
    } 
}
