import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AutorListaComponent } from './autor-lista/autor-lista.component';


const routes: Routes = [
  { path: '', component: AutorListaComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AutorRoutingModule { }
