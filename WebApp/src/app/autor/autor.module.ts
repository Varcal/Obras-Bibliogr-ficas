import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { AutorRoutingModule } from './autor-routing.module';
import { AutorListaComponent } from './autor-lista/autor-lista.component';


@NgModule({
  declarations: [AutorListaComponent],
  imports: [
    CommonModule,
    AutorRoutingModule,
    FormsModule
  ]
})
export class AutorModule { }
