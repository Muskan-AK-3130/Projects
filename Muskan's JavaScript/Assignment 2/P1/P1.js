validate_billNumber(billNumber, s1)
{
    if (billNumber.value == "") 
    {
        s1.innerHTML = "Enter Bill Number"; 
        billNumber.focus();
        return false;
    }
    else
    if (billNumber.value <= 0) 
    {
        s1.innerHTML = "Enter Valid Bill Number";
        billNumber.focus();
        return false;
    }
    else 
    {
        s1.innerHTML = "";
        return true;
    }
}
function validate_billDate(billDate, s2) 
{    
    if (billDate.value == "") 
    {
        s2.innerHTML = "Select Bill Date"; 
        billDate.focus();
        return false;
    }
    else 
    {
        s2.innerHTML = "";
        return true;        
    }
}
function validate_billAmount(billAmt, s3) 
{
    if (billAmt.value == "") 
    {
        s3.innerHTML = "Enter Bill Amount";
        billAmt.focus();
        return false;
    }
    else
    if (billAmt.value <= 0) 
    {
        s3.innerHTML = "Enter Valid Bill Amount"; 
        billAmt.focus();
        return false;
    }
    else 
    {
        s3.innerHTML = "";
        return true;     
    }
}
function validate_form()
{
    let bn = document.getElementById('billNo')
    let bd = document.getElementById('billDate')
    let ba = document.getElementById('billAmt')

    s1 = document.getElementById('s1')
    s2 = document.getElementById('s2')
    s3 = document.getElementById('s3')
    if (validate_billNumber(bn,s1) && validate_billDate(bd,s2) && validate_billAmount(ba,s3))
         return true;
    else
         return false;
}
function calculateBill() 
            {
                let bd = new Date(document.getElementById("billDate").value).getDay()
                let ba = parseInt(document.getElementById("billAmt").value)
                let disc
                if (validate_form()) 
                {
                    if (bd == 1 || bd == 2)
                        disc = parseInt(ba * 0.10)
                    else
                    if (bd == 3 || bd == 4)
                        disc = parseInt(ba * 0.15)
                    else
                        disc = parseInt(ba * 0.05)
                    document.getElementById("discount").value = disc
                    document.getElementById("tax").value = parseInt(ba * 0.05)
                    document.getElementById("netPayment").value = (parseInt(ba - disc + (parseInt(ba * 0.05))))
                    document.getElementById("d1").innerHTML = "Bill Successfully Generated"
                }
                else 
                {
                    document.getElementById("d1").innerHTML = "Please fill all the fields"
                }
            }
            function first_focus() 
            {
                document.getElementById("billNo").focus();
            }
