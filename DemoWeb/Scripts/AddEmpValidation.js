function validate() {
    var eno = document.getElementById("txtemp").value;
    var en = document.getElementById("txtename").value;
    var job = document.getElementById("txtjob").value;
    var mgr = document.getElementById("txtmgr").value;
    var hr = document.getElementById("txthiredate").value;
    var sal = document.getElementById("txtsal").value;
    var cmm = document.getElementById("txtcomm").value;
    var dno = document.getElementById("txtdept").value;
    if (eno.length == 0 || en.length == 0 || job.length == 0 || mgr.length == 0 || hr.length == 0 || sal.length == 0 || cmm.length == 0 || dno.length == 0)
    {
        alert("enter all details");
        return false;
    }
    else
        return true;

}