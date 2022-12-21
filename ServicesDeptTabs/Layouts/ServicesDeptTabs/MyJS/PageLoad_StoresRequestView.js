﻿var requestID;
var source;
var adapter;
var EmpArabicName;
var EmpEmail;
var Status;
var DM;
var ServicesDivisionHead_email;
var EmpFor_StoresRequests_email;
var DMemail;

$.urlParam = function (name) {
    var results = new RegExp('[\?&]' + name + '=([^&#]*)').exec(window.location.href);
    if (results === null) {
        return null;
    }
    else {
        return decodeURI(results[1]) || 0;
    }
};

$(document).ready(function () {

    requestID = $.urlParam('srid');

    //==============================================================

    sprLib.list('RequestReceiverEmail').items({
        listCols: ['Email'],
        queryFilter: 'Title eq "ServicesDivisionHead_email"'  
    })
        .then(function (arrData) {
            ServicesDivisionHead_email = arrData[0].Email;
        })
        .catch(function (errMsg) { console.error(errMsg); });

    sprLib.list('RequestReceiverEmail').items({
        listCols: ['Email'],
        queryFilter: 'Title eq "EmpFor_StoresRequests_email"'
    })
        .then(function (arrData) {
            EmpFor_StoresRequests_email = arrData[0].Email;
        })
        .catch(function (errMsg) { console.error(errMsg); }); 

    //==============================================================

    sprLib.list('StationeryRequests').items({
        listCols: ['Created', 'Department', 'EmpArabicName', 'EmpEmail', 'Status', 'DM','DMemail'],
        queryFilter: 'ID eq ' + requestID
    })
        .then(function (arrData) {

            var date = new Date(arrData[0].Created);
            var formatDate = date.toLocaleString('en-GB', { year: "numeric", month: "numeric", day: "numeric" });
            $('#lbl_ReqDate').text(formatDate);
            $('#lblEmpName').text(arrData[0].EmpArabicName);
            $('#lblDept').text(arrData[0].Department);
            EmpArabicName = arrData[0].EmpArabicName;
            EmpEmail = arrData[0].EmpEmail;
            Status = arrData[0].Status;
            DM = arrData[0].DM;
            DMemail = arrData[0].DMemail;
            //==Checking the Request Status and Show/Hide Controls accordingly
            CheckRequestStatusAndShowHideControlsAccordingly();

        })
        .catch(function (errMsg) { console.error(errMsg); });

    //==============================================================

    sprLib.list('StationeryRequestDetails').items({
        listCols: ['ID', 'MasterRecordId', 'Title', 'Quantity', 'Notes'],
        queryFilter: 'MasterRecordId eq ' + requestID,
        queryOrderby: 'ID'
    })
        .then(function (arrData) {
            BindArrayToGrid(arrData);
        })
        .catch(function (errMsg) { console.error(errMsg); });

}); // end of document.readyfunction BindArrayToGrid(data) {
    source = {
        localdata: data,
        datafields: [{
            name: 'Title',
            type: 'string'
        }, {
            name: 'Quantity',
            type: 'string'
        }, {
            name: 'Notes',
            type: 'string'
        }],
        datatype: "array"
    };
    adapter = new $.jqx.dataAdapter(source);
    $("#jqxgrid").jqxGrid({
        rtl: true,
        width: 900,
        height: 200,
        source: adapter,
        columns: [
            {
                text: 'اسم الصنف',
                datafield: 'Title',
                width: 400,
                editable: false,
                align: 'right',
                cellsalign: 'right',
                cellclassname: 'GridCellStyle'
            }, {
                text: 'الكمية',
                datafield: 'Quantity',
                width: 100,
                columntype: 'numberinput',
                align: 'right',
                cellsalign: 'right',
                cellclassname: 'GridCellStyle'
            }, {
                text: 'ملاحظات',
                datafield: 'Notes',
                width: 400,
                align: 'right',
                cellsalign: 'right',
                cellclassname: 'GridCellStyle'
            }
        ]  // end of columns
    });

}