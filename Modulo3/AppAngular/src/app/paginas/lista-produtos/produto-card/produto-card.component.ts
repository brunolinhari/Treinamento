import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Produto } from 'src/app/models/produto';

@Component({
  selector: 'BOL-produto-card',
  templateUrl: './produto-card.component.html',
  styles: []
})
export class ProdutoCardComponent {

  @Input()
  produto: Produto;

  @Output()
  selecionado: EventEmitter<Produto> = new EventEmitter();

  promocao() {
    this.selecionado.emit(this.produto);
  }

  
}
