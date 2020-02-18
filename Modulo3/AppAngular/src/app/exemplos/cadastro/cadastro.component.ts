import { Component, OnInit, AfterViewInit, ViewChildren, ElementRef } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators, FormControlName } from '@angular/forms';
import { NgBrazilValidators } from 'ng-brazil';
import { utilsBr } from 'js-brasil';
import { CustomValidators } from 'ng2-validation';
import { ValidationMessages, GenericValidator, DisplayMessage } from 'src/app/generic-validator';
import { Observable, fromEvent, merge } from 'rxjs';

@Component({
  selector: 'BOL-cadastro',
  templateUrl: './cadastro.component.html',
  styles: []
})
export class CadastroComponent implements OnInit, AfterViewInit {
  @ViewChildren(FormControlName, { read: ElementRef}) formImputElements: ElementRef[];

  alteracoesPendentes: boolean;
  cadastroForm: FormGroup;

  public MASKS = utilsBr.MASKS;

   validationMessages: ValidationMessages;
   genericValidator: GenericValidator;
   displayMessage: DisplayMessage = {};

  constructor(private fb: FormBuilder) {
     this.validationMessages = {
       nome: {
         required: 'O Nome é requerido',
         rangeLength: 'O Nome precisa ter no mínimo 2 e no máximo 15 caracteres'
       },
       cpf: {
         required: 'Informe o CPF',
         cpf: 'CPF em formato inválido'
       },
       email: {
         required: 'Informe o e-mail',
         email: 'Email inválido'
       },
       senha: {
         required: 'Informe a senha',
         rangeLength: 'A senha deve possuir entre 6 e 15 caracteres'
       },
       confirmarSenha: {
         required: 'Informe a senha novamente',
         rangeLength: 'A senha deve possuir entre 6 e 15 caracteres',
         equalTo: 'As senhas não conferem'
       }
     };

     this.genericValidator = new GenericValidator(this.validationMessages);
  }

  ngOnInit() {
    //this.cadastroForm = new FormGroup({
    //  nome: new FormControl(''),
    //  email: new FormControl(''),
    //  cpf: new FormControl(''),
    //  senha: new FormControl(''),
    //  confirmarSenha: new FormControl('')
    //})
  
    //this.cadastroForm = this.fb.group({
    //  nome: ['', [Validators.required,CustomValidators.rangeLength([2, 15])]],
    //  email: ['', [Validators.required, Validators.email]],
    //  cpf: ['', [Validators.required, NgBrazilValidators.cpf]], 
    //  senha: ['', [Validators.required, CustomValidators.rangeLength([6, 10])]],
    //  confirmarSenha: ['', [Validators.required, CustomValidators.rangeLength([6, 10])]]
    //})

    let senha = new FormControl('', [Validators.required, CustomValidators.rangeLength([6, 10])]);
    let confirmarSenha = new FormControl('', 
    [
      Validators.required, 
      CustomValidators.rangeLength([6, 10]),
      CustomValidators.equalTo(senha)
    ]);
    
    this.cadastroForm = this.fb.group({
      nome: ['', [Validators.required,CustomValidators.rangeLength([2, 15])]],
      email: ['', [Validators.required, Validators.email]],
      cpf: ['', [Validators.required, NgBrazilValidators.cpf]], 
      senha: senha,
      confirmarSenha: confirmarSenha
    })
  }

  ngAfterViewInit(): void {
    let controlBlurs: Observable<any>[] = this.formImputElements.map((FormControl: ElementRef) => fromEvent(FormControl.nativeElement, 'blur'));
    merge(...controlBlurs).subscribe(() => {
      this.displayMessage = this.genericValidator.processarMensagens(this.cadastroForm);
      this.alteracoesPendentes = true;
    });
  }

  salvar(){
    console.log(this.cadastroForm.value);

    this.alteracoesPendentes = false;
  }

}
