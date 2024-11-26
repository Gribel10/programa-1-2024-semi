
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;

using System;

< !DOCTYPE html >
< html >
< head >
    < meta charset = "utf-8" />
    < title > Aplicacion Academica </ title >
    < link href = "https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel = "stylesheet"
          integrity = "sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin = "anonymous" >
</ head >
< body >
    < div class= "container-fluid" >
        < div class= "row" >
            < div class= "col-12 col-md-6" >
                < div class= "card text-bg-dark mb-3" >
                    < div class= "card-header" > Registro de Alumnos</div>
                    <div class= "card-body" >
                        < form id = "frmAlumno" data - idalumno = "0" data - accion = "nuevo" >
                            < div class= "row p-1" >
                                < div class= "col-3 col-md-2" > CODIGO:</ div >
                                < div class= "col-9 col-md-4" >
                                    < input type = "text" class= "form-control" id = "txtCodigoAlumno" name = "txtCodigoAlumno" required >
                                </ div >
                            </ div >
                            < div class= "row p-1" >
                                < div class= "col-3 col-md-2" > NOMBRE:</ div >
                                < div class= "col-9 col-md-8" >
                                    < input type = "text" class= "form-control" id = "txtNombreAlumno" name = "txtNombreAlumno" required >
                                </ div >
                            </ div >
                            < div class= "row p-1" >
                                < div class= "col-3 col-md-2" > DIRECCION:</ div >
                                < div class= "col-9 col-md-10" >
                                    < input type = "text" class= "form-control" id = "txtDireccionAlumno" name = "txtDireccionAlumno" required >
                                </ div >
                            </ div >
                            < div class= "row p-1" >
                                < div class= "col-3 col-md-2" > TELEFONO:</ div >
                                < div class= "col-9 col-md-4" >
                                    < input type = "text" class= "form-control" id = "txtTelefonoAlumno" name = "txtTelefonoAlumno" required >
                                </ div >
                            </ div >
                            < div class= "row p-1" >
                                < div class= "col-12" >
                                    < input type = "submit" class= "btn btn-primary" value = "Guardar" >
                                    < input type = "reset" class= "btn btn-warning" value = "Nuevo" >
                                </ div >
                            </ div >
                        </ form >
                    </ div >

< form id = "frmAlumno" data - idalumno = "0" data - accion = "nuevo" >
    < div class= "card text-bg-dark mb-3" style = "min-width:700px;" >
        < div class= "card-header" >
            < div class= "d-flex" >
                Registro de Alumnos
                <div class= "ms-auto" >
                    < button type = "button" data - form = "alumno" class= "btn-close btn-close-white" ></ button >
                </ div >
            </ div >
            < div class= "col-12 col-md-6" >
                < div class= "card text-bg-dark mb-3" >
                    < div class= "card-header" > Consulta de Alumnos</div>
                    <div class= "card-body" >
                        < table class= "table table-dark table-hover" id = "tblListadoAlumnos" >
                            < thead >
                                < tr >
                                    < th > CODIGO </ th >
                                    < th > NOMBRE </ th >
                                    < th > DIRECCION </ th >
                                    < th > TELEFONO </ th >
                                    < th ></ th >
                                </ tr >
                            </ thead >
                            < tbody > </ tbody >
                        </ table >
                    </ div >
        </ div >
        < div class= "card-body" >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > CODIGO:</ div >
                < div class= "col-9 col-md-4" >
                    < input type = "text" class= "form-control" id = "txtCodigoAlumno" name = "txtCodigoAlumno" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > NOMBRE:</ div >
                < div class= "col-9 col-md-8" >
                    < input type = "text" class= "form-control" id = "txtNombreAlumno" name = "txtNombreAlumno" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > DIRECCION:</ div >
                < div class= "col-9 col-md-10" >
                    < input type = "text" class= "form-control" id = "txtDireccionAlumno" name = "txtDireccionAlumno" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-3 col-md-2" > TELEFONO:</ div >
                < div class= "col-9 col-md-4" >
                    < input type = "text" class= "form-control" id = "txtTelefonoAlumno" name = "txtTelefonoAlumno" required >
                </ div >
            </ div >
            < div class= "row p-1" >
                < div class= "col-12" >
                    < input type = "submit" class= "btn btn-primary" value = "Guardar" >
                    < input type = "reset" class= "btn btn-warning" value = "Nuevo" >
                    < button type = "button" class= "btn btn-success" onclick = "abrirVentanas('busqueda_alumno')" > Buscar </ button >
                </ div >
            </ div >
        </ div >
    </ div >
</ form >


    < script >
        document.addEventListener("DOMContentLoaded", event => {
    listarAlumnos();
    frmAlumno.addEventListener('submit', e => {
        e.preventDefault();
        guardarAlumnos();
    });

    frmAlumno.addEventListener('submit', e => {
        e.preventDefault();
        guardarAlumnos();
    });
    frmAlumno.addEventListener('reset', e => {
        e.preventDefault();
        limpiarDatosAlumnos();
    });
    async function guardarAlumnos()
    {
        let datos = {
@@ -102,31 +75,15 @@
                body: JSON.stringify(datos)
            }), alumno = await respuesta.json();
if (alumno && alumno?.idAlumno > 0)
{
    alertify.success("Alumno guardado con exito.");
    listarAlumnos();
    limpiarDatosAlumnos();
}
else
{
    alertify.error(`Erro al intentar guardar el alumno: ${ alumno}`);
    conosle.log(alumno);
}
        }
        async function listarAlumnos()
{
    const respuesta = await fetch("https://localhost:7041/api/Alumnos", {
    method: "GET",
                headers:
        {
            "Content-Type": "application/json"
                }
            }), alumnos = await respuesta.json();
let filas = "";
alumnos.forEach(alumno => {
filas += `< tr onClick = 'modificarAlumno(${JSON.stringify(alumno)})' >

    < td >${ alumno.codigo}</ td >

    < td >${ alumno.nombre}</ td >

    < td >${ alumno.direccion}</ td >

    < td >${ alumno.telefono}</ td >

    < td >< button class= "btn btn-danger" onClick = 'eliminarAlumno(${JSON.stringify(alumno)})' > DEL </ button ></ td >

</ tr >`;
            });
document.querySelector("#tblListadoAlumnos > tbody").innerHTML = filas;
        }
        
        function modificarAlumno(alumno)
{
    frmAlumno.dataset.idalumno = alumno.idAlumno;
    frmAlumno.dataset.accion = "modificar";
@@ -143,23 + 100,4 @@
            txtDireccionAlumno.value = "";
    txtTelefonoAlumno.value = "";
}
async function eliminarAlumno(alumno)
{
    if (confirm(`Esta seguro de eliminar a ${ alumno.nombre}`)) {
        let respuesta = await fetch(`https://localhost:7041/api/Alumnos/${alumno.idAlumno}`, {
            method: "DELETE",
                    headers:
{
    "Content-Type": "application/text"
                    }
                }),
                    datos = await respuesta.text();//""
if (datos && datos.length > 0)
{
    console.log(datos);
}
else
{
    limpiarDatosAlumnos();
    listarAlumnos();
}
            }
        }
    </ script >
</ body >
</ html >
    </ script >
‎sistema_academico / sistema_academico / wwwroot / views / busqueda_alumno.html
+ 72
Original file line number	Diff line number	Diff line change
@@ -0,0 +1,72 @@
﻿<form id="frmBusquedaAlumno">
        <div class= "card text-bg-dark mb-3" >
            < div class= "card-header" >
                < div class= "d-flex" >
                    Consulta de Alumnos
                    <div class= "ms-auto" >
                        < button type = "button" data - form = "busqueda_alumno" class= "btn-close btn-close-white" ></ button >
                    </ div >
                </ div >
            </ div >
            < div class= "card-body" >
                < table class= "table table-dark table-hover" id = "tblListadoAlumnos" >
                    < thead >
                        < tr >
                            < th > CODIGO </ th >
                            < th > NOMBRE </ th >
                            < th > DIRECCION </ th >
                            < th > TELEFONO </ th >
                            < th ></ th >
                        </ tr >
                    </ thead >
                    < tbody > </ tbody >
                </ table >
            </ div >
        </ div >
</ form >
< script >
    listarAlumnos();

async function listarAlumnos()
{
    const respuesta = await fetch("/api/Alumnos", {
    method: "GET",
            headers:
        {
            "Content-Type": "application/json"
            }
        }), alumnos = await respuesta.json();
let filas = "";
alumnos.forEach(alumno => {
filas += `< tr onClick = 'modificarAlumno(${JSON.stringify(alumno)})' >

< td >${ alumno.codigo}</ td >

< td >${ alumno.nombre}</ td >

< td >${ alumno.direccion}</ td >

< td >${ alumno.telefono}</ td >

< td >< button class= "btn btn-danger" onClick = 'eliminarAlumno(${JSON.stringify(alumno)}, event)' > DEL </ button ></ td >

</ tr >`;
        });
document.querySelector("#tblListadoAlumnos > tbody").innerHTML = filas;
    }
    function eliminarAlumno(alumno, e)
{
    e.preventDefault();
    limpiarDatosAlumnos();
    alertify.confirm("Eliminar alumnos", `Esta seguro de eliminar a ${ alumno.nombre}`, async (e) => {
        let respuesta = await fetch(`/ api / Alumnos /${ alumno.idAlumno}`, {
        method: "DELETE",
                headers:
            {
                "Content-Type": "application/text"
                }
            }),
                datos = await respuesta.text();//""
if (datos && datos.length > 0)
{
    alertify.error(`Nose pudo eliminar el alumno: ${ datos}`);
    console.log(datos);
}
else
{
    limpiarDatosAlumnos();
    listarAlumnos();
}
        }, () => {
               alertify.warning("Eliminacion cancelada.");
           });
    }
</ script >
‎sistema_academico / sistema_academico / wwwroot / views / index.html
+ 56
- 12
Original file line number	Diff line number	Diff line change
@@ -3,34 +3,78 @@
<head>
    <meta charset="utf-8" />
    <title>Sistema Academico</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" 
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
          integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <!-- CSS -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.14.0/build/css/alertify.min.css" />
    <!-- Default theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.14.0/build/css/themes/default.min.css" />
    <!-- Semantic UI theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.14.0/build/css/themes/semantic.min.css" />
    <!-- Bootstrap theme -->
    <link rel="stylesheet" href="//cdn.jsdelivr.net/npm/alertifyjs@1.14.0/build/css/themes/bootstrap.min.css" />
</head>
<body>
    <nav class= "navbar navbar-expand-lg bg-body-tertiary" >
        < div class= "container-fluid" >
            < a class= "navbar-brand" href = "#" >::.SISTEMA ACADEMICO.::</ a >
            < a class= "navbar-brand" href = "#" >
                < img src = "/img/logo.png" height = "50" />
            </ a >
            < button class= "navbar-toggler" type = "button" data - bs - toggle = "collapse" data - bs - target = "#navbarNavAltMarkup" aria - controls = "navbarNavAltMarkup" aria - expanded = "false" aria - label = "Toggle navigation" >
                < span class= "navbar-toggler-icon" ></ span >
            </ button >
            < div class= "collapse navbar-collapse" id = "navbarNavAltMarkup" >
                < div class= "navbar-nav" >
                    < a class= "nav-link" href = "#" > Alumnos </ a >
                    < a class= "nav-link" href = "#" > Docentes </ a >
                    < a class= "nav-link" href = "#" > Materias </ a >
                < div class= "navbar-nav" id = "mnxAcademica" >
                    < a class= "nav-link" href = "#" data - form = "alumno" > Alumnos </ a >
                    < a class= "nav-link" href = "#" data - form = "docente" > Docentes </ a >
                    < a class= "nav-link" href = "#" data - form = "materia" > Materias </ a >
                </ div >
            </ div >
        </ div >
    </ nav >
    < div class= "container-fluid" >
        < div class= "position-absolute" id = "alumnos" ></ div >
        < div class= "position-absolute" id = "busqueda_alumnos" ></ div >
        < div class= "position-absolute" id = "alumno" ></ div >
        < div class= "position-absolute" id = "busqueda_alumno" ></ div >

        < div class= "position-absolute" id = "docentes" ></ div >
        < div class= "position-absolute" id = "busqueda_docentes" ></ div >
        < div class= "position-absolute" id = "docente" ></ div >
        < div class= "position-absolute" id = "busqueda_docente" ></ div >

        < div class= "position-absolute" id = "materias" ></ div >
        < div class= "position-absolute" id = "busqueda_materias" ></ div >
        < div class= "position-absolute" id = "materia" ></ div >
        < div class= "position-absolute" id = "busqueda_materia" ></ div >
    </ div >
    < script src = "https://code.jquery.com/jquery-3.7.1.min.js"
            integrity = "sha256-/JqT3SQfawRcv/BIHPThkBvs0OEvtFFmqPF/lYI/Cxo="
            crossorigin = "anonymous" ></ script >
    < script src = "https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.14.1/jquery-ui.min.js"
            integrity = "sha512-MSOo1aY+3pXCOCdGAYoBZ6YGI0aragoQsg1mKKBHXCYPIWxamwOE7Drh+N5CPgGI5SA9IEKJiPjdfqWFWmZtRA=="
            crossorigin = "anonymous" referrerpolicy = "no-referrer" ></ script >
    < script src = "//cdn.jsdelivr.net/npm/alertifyjs@1.14.0/build/alertify.min.js" ></ script >
    < script >
        document.addEventListener("DOMContentLoaded", event => {
    mnxAcademica.addEventListener("click", e => {
        e.preventDefault();
        abrirVentanas(e.target.dataset.form);
    });
});
function abrirVentanas(form)
{
    let $form = $(`#${form}`);
            if ($form.find("form").length > 0) {
                $form.show();
    } else
    {
        let url = `/ views /${ form}.html`;
        fetch(url).then(resp => resp.text()).then(vista => {
                    $(`#${form}`).html(vista).draggable();
                    cerrarVentana();
        });
    }
}
function cerrarVentana()
{
            $(".btn-close").click(e => {
                 let form = e.target.dataset.form;
                $(`#${form}`).hide();
            });
}
    </ script >
</ body >
</ html >