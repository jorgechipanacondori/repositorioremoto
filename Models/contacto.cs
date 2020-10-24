using System;


namespace FORMULARIO.Models

public class Contacto
{
 [Required(ErrorMessage = "Por favor ingrese nombre "]
 [Display(Name="Nombre")]

 public string Name{get;set;}

 [Required(ErrorMessage = "Por favor ingrese nombre "]
 [Display(Name="Apellido")]
public string LastName{get;set;}

[Display(Name="Distrito")]
public string Distrito{get;set;}



}