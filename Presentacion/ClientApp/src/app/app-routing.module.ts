import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonaConsultaComponent } from './beneficiarios/persona-consulta/persona-consulta.component';
import { PersonaRegistroComponent } from './beneficiarios/persona-registro/persona-registro.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [

  {path: 'personaConsulta',component: PersonaConsultaComponent},
  {path: 'personaRegistro',component: PersonaRegistroComponent}
  
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule] 
})
export class AppRoutingModule { }