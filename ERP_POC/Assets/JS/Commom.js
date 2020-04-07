
MessageType={success:1 , error:2  }
IsReturn = false;

function LoadPartialDiv(Jsondata) {
 
    $.ajax(
          {
              type: Jsondata.TYPE,
              url: Jsondata.URL,
              data: Jsondata.DATA,
              dataType: Jsondata.DATATYPE,
              //if async is false then one ajax request compeleted then call other ajax until other ajax is waiting
                async: false,
              beforeSend: function () {
                  $("#DivProgress").fadeIn("fast");
              },
              success: function (data) {
                  
                  $(""+Jsondata.PARTIALDIV+"").html("");
                  $("" + Jsondata.PARTIALDIV + "").html(data);
                
                  $("#DivProgress").fadeOut(1500);
                  return false;
              },
              error: function (data) { }
          });

    return false;
}

 
function SaveData(Jsondata) {
    IsReturn = false;
    $.ajax(
       {
           type: Jsondata.TYPE,
           url: Jsondata.URL,
           data: Jsondata.DATA,
           dataType: Jsondata.DATATYPE,
           //if async is false then one ajax request compeleted then call other ajax until other ajax is waiting
           async: false,
           beforeSend: function () {
               $("#DivProgress").fadeIn("fast");
           },
           success: function (data) {
               
               if (data.MessageType = MessageType.success) {
                   IsReturn = true;
               }
               alert(data.Message);
               $("#DivProgress").fadeOut(1500);
               return IsReturn;
           },
           error: function (data) { }
       });
    return IsReturn;
}

function DeleteData(Jsondata) {
    IsReturn = false;
    $.ajax(
          {
              type: Jsondata.TYPE,
              url: Jsondata.URL,
              data: Jsondata.DATA,
              dataType: Jsondata.DATATYPE,
              //if async is false then one ajax request compeleted then call other ajax until other ajax is waiting
              async: false,
              beforeSend: function () {
                  $("#DivProgress").fadeIn("fast");
              },
              success: function (data) {
                  if (data.MessageType = MessageType.success) {
                      IsReturn = true;
                  }
                  alert(data.Message);
                  $("#DivProgress").fadeOut(1500);
                  return IsReturn;
              },
              error: function (data) { }
          });

    return IsReturn;
}

function Toaster() {
     alert(data.Message);
}