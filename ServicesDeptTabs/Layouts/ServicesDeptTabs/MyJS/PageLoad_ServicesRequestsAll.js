﻿var user = null;
$(document).ready(function () {
    ReadCategories();
    GetUserInfo();
        listCols: ['Email'],
        queryFilter: 'Title eq "ServicesDivisionHead_email"'
    })
        .then(function (arrData) {
            ServicesDivisionHead_email = arrData[0].Email;
        })
        .catch(function (errMsg) { console.error(errMsg); });

            .then(function (objUser) {
            });
            .then(function (objProps) {

                userDisplayName = UserInfo.DisplayName;
                console.log('userDisplayName is ' + userDisplayName);

                userEmail = UserInfo.Email;
                console.log('userEmail is ' + userEmail);

                EmpArabicName = UserInfo.UserProfileProperties.AboutMe;
                console.log('EmpArabicName is ' + EmpArabicName);

                Department = UserInfo.UserProfileProperties.Department;
                console.log('Department is ' + Department);

                DM = UserInfo.UserProfileProperties.Manager;
                console.log('DM is ' + DM);

                ExtendedManagersLength = UserInfo.ExtendedManagers.length;
                console.log('ExtendedManagersLength is ' + ExtendedManagersLength);
                

                var webURL = _spPageContextInfo.webAbsoluteUrl;
            });
        width: '60px',
        height: '30px',
        spinButtons: true,
        decimal: 1,
        digits: 3,
        decimalDigits: 0,
        min: 1,
        max: 999,
        promptChar: ''
    });

    $("#btnAddStationeryItemToGrid").on('click', function () {
        AddStationeryItemToGrid();
    });

    var row = {};
    var source = {
        localdata: row,
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
    var adapter = new $.jqx.dataAdapter(source);
    $("#jqxgrid").jqxGrid({
        rtl: true,
        width: 900,
        height: 200,
        source: adapter,
        editable: true,
        selectionmode: 'singlerow',
        editmode: 'dblclick',
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
                cellclassname: 'GridCellStyle',
                validation: function (cell, value) {
                    if (value < 1 || value > 999) {
                        return { result: false, message: "لابد أن تكون الكمية من 1 إلى 999" };
                    }
                    return true;
                },
                createeditor: function (row, cellvalue, editor) {
                    editor.jqxNumberInput({ width: '60px', height: '30px', spinButtons: true, decimal: 1, digits: 3, decimalDigits: 0, min: 1, max: 999, promptChar: '' });
                }
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
}); // end of document.ready
