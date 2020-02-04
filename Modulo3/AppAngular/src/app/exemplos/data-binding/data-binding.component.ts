import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'BOL-data-binding',
  templateUrl: './data-binding.component.html'
})
export class DataBindingComponent {
  
  public contador: number = 0;
  public urlImagem: string = "https://www.texs.com.br/Arquivos/Texto/img-quem-somos.svg"

  incrementaContador(){
    this.contador += 1;
    //console.log("clicado");
  }

  zerarContador(){
    this.contador = 0;
    //console.log("clicado");
  }

}
