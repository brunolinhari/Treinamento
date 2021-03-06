import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ContatoComponent } from './paginas/contato/contato.component';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './paginas/home/home.component';
import { DataBindingComponent } from './exemplos/data-binding/data-binding.component';
import { HttpClientModule } from '@angular/common/http';
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';
import { CadastroComponent } from './exemplos/cadastro/cadastro.component';
import { TextMaskModule } from 'angular2-text-mask';
import { NgBrazil } from 'ng-brazil';
import { CustomFormsModule } from 'ng2-validation';
import { ComumModule } from './comum/comum.module';
import { AppRoutingModule } from './app.routes';
import { AuthGuardService } from './services/auth-guard.service';
import { CadastroGuardService } from './exemplos/cadastro/cadastro-guard.service';
//import { CustomValidators, CustomFormsModule } from 'ng2-validation';
registerLocaleData(localePt);

@NgModule({
  declarations: [
    AppComponent,
    ContatoComponent,
    HomeComponent,
    DataBindingComponent,
    CadastroComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
 
    ComumModule,
 
    ReactiveFormsModule,
    TextMaskModule,
    NgBrazil,
    CustomFormsModule,
    AppRoutingModule
  ],
  providers: [AuthGuardService, CadastroGuardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
