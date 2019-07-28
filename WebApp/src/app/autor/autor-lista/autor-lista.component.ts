import { Component, OnInit } from '@angular/core';
import { AutorService } from 'src/app/services/autor.service';
import { Autor } from './autor';

@Component({
  selector: 'app-autor-lista',
  templateUrl: './autor-lista.component.html',
  styleUrls: ['./autor-lista.component.css'],
  preserveWhitespaces: true
})
export class AutorListaComponent implements OnInit {
  quantidade: number;
  autores: Autor[];

  constructor(private autorService: AutorService) { 
   
  }

  ngOnInit() {
  }

  selecionarPorQuantidade(){

    if(this.quantidade == null) {
      this.quantidade = 0;
    }

     this.autorService.selecionarPorQuantidade(this.quantidade)
            .subscribe(response => this.autores = response)    
  }
}
