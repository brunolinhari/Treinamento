import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { MenuComponent } from './comum/menu/menu.component';
import { FooterComponent } from './comum/footer/footer.component';
import { ListaProdutosComponent } from './paginas/lista-produtos/lista-produtos.component';
import { ContatoComponent } from './paginas/contato/contato.component';
import { RouterModule } from '@angular/router';
import { rootRouterConfig } from './app.routes';
import { HomeComponent } from './paginas/home/home.component';
import { NaoEncontradaComponent } from './comum/nao-encontrada/nao-encontrada.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';
import { HttpClientModule } from '@angular/common/http';
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';
import { CadastroComponent } from './exemplos/cadastro/cadastro.component';
import { TextMaskModule } from 'angular2-text-mask';
import { NgBrazil } from 'ng-brazil';
import { CustomValidators, CustomFormsModule } from 'ng2-validation';
registerLocaleData(localePt);

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    FooterComponent,
    ListaProdutosComponent,
    ContatoComponent,
    HomeComponent,
    NaoEncontradaComponent,
    DataBindingComponent,
    CadastroComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    TextMaskModule,
    NgBrazil,
    CustomValidators,
    CustomFormsModule,
    [RouterModule.forRoot(rootRouterConfig, {useHash: false})]
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
