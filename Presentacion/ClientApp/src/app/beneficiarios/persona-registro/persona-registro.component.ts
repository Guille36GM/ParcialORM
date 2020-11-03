import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PersonaService } from 'src/app/services/persona.service';
import { Persona } from '../models/persona';

@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: ['./persona-registro.component.css']
})
export class PersonaRegistroComponent implements OnInit {

  formGroup: FormGroup;
  persona: Persona;

  constructor(private personaService: PersonaService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.persona = new Persona();
    this.buildForm();
  }

  private buildForm() {

    this.persona = new Persona();
    this.persona.identificacion = '';
    this.persona.nombre = '';
    this.persona.apellido = '';
    this.persona.sexo = '';
    this.persona.edad = null;
    this.persona.departamento = '';
    this.persona.ciudad = '';
    this.persona.tipo = '';
    this.persona.valor = null;
    this.persona.fecha = '';

    this.formGroup = this.formBuilder.group({
      identificacion: [this.persona.identificacion, Validators.required],
      nombre: [this.persona.nombre, Validators.required],
      apellido: [this.persona.apellido, Validators.required],
      sexo: [this.persona.sexo, Validators.required],
      edad: [this.persona.edad, [Validators.required, Validators.min(1)]],
      departamento: [this.persona.departamento, Validators.required],
      ciudad: [this.persona.ciudad, Validators.required],
      tipo: [this.persona.tipo, Validators.required],
      valor: [this.persona.valor, [Validators.required, this.ValidarValor]],
      fecha: [this.persona.fecha, Validators.required],
     });  
  }

  private ValidarValor(control: AbstractControl) {

    const valor = control.value;    
    if (valor <= 0 || valor > 600000000) {
       return { ValidarValor: true, message: 'El valor ingresado no es valido'};      
    }   
    return null;    
  }

  get control() {
    return this.formGroup.controls;    
  }

  onSubmit() {
    if (this.formGroup.invalid) {    
    return;    
    }    
    this.add();    
  }
  add(){    
    this.personaService.post(this.persona).subscribe(p => {
      if(p != null){
        alert('Se agregó una nueva persona');
        this.persona = p;
      }
    })
  }  
}
