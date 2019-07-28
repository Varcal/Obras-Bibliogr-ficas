import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Autor } from '../autor/autor-lista/autor';

@Injectable({
  providedIn: 'root'
})
export class AutorService {

  private readonly API = 'http://localhost:5000/api/autor/' 

  constructor(private http: HttpClient) { 

  }

  selecionarPorQuantidade(quantidade: number){
    return this.http.get<Autor[]>(this.API + "selecionarPorQuantidade/"+ quantidade);
  }
}
