import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { MenuComponent } from './menu/menu.component';
import { NaoEncontradaComponent } from './nao-encontrada/nao-encontrada.component';
import { FooterComponent } from './footer/footer.component';



@NgModule({
  declarations: [
    FooterComponent,
    MenuComponent, 
    NaoEncontradaComponent
    ],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [
    FooterComponent,
    MenuComponent, 
    NaoEncontradaComponent
  ]
})
export class ComumModule { }
