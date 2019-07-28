import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';


const routes: Routes = [
  { path:'', pathMatch: 'full' , component: HomeComponent },
  { path:'autor', loadChildren: './autor/autor.module#AutorModule' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
