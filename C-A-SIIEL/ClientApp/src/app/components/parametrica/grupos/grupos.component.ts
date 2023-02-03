import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Titulos } from '../../inventario/models/titulos';

@Component({
  selector: 'app-grupos',
  templateUrl: './grupos.component.html',
  styleUrls: ['./grupos.component.css']
})
export class GruposComponent implements OnInit {
  public toDay: Date = new Date();   //import date management GECS
  form!: FormGroup;
 
  notFound: boolean = false;
  EmplArray: Titulos[] = [
    { id: 1, title: "Nombre1 Registro Tabla", descripcionT: "Descripción1 Regitro Tabla", done: true, createdDate: this.dateString1, updatedDate: "2000-01-11" },
    { id: 2, title: "Nombre2 Registro Tabla", descripcionT: "Descripción2 Regitro Tabla", done: true, createdDate: this.dateString1, updatedDate: "2010-10-10" },
  ];
  selec: Titulos = new Titulos();

  constructor(private formBuilder: FormBuilder,
    private datePipe: DatePipe,
    private router: Router) { }

  ngOnInit() {
    this.toDay = new Date();   //import date management GECS
    console.log(this.datePipe.transform(this.toDay, "yyyy-MM-dd"));  //import date management GECS
    this.form = this.formBuilder.group({
      title: [this.selec.title, Validators.required],
      descripcionT: [this.selec.descripcionT, Validators.required],
      //createdDate: [this.sel.createdDate, Validators.required], // para q funcione [disabled]="form.invalid" para submit
      createdDate: [this.selec.createdDate],
      done: [this.selec.done],
      updatedDate: [this.selec.updatedDate, Validators.required],
    });
  }

  openForEdit(e: Titulos) {
    this.selec = e;
    this.form = this.formBuilder.group({
      title: [this.selec.title, Validators.required],
      descripcionT: [this.selec.descripcionT, Validators.required],
      done: [this.selec.done],
      createdDate: [this.selec.createdDate],
      updatedDate: [this.selec.updatedDate, Validators.required],
    });
  }

  AddEdit() {
    // NO hay empleado seleccionado == 0, es nuevo empleado
    if (this.selec.id === 0) {
      this.selec.id = this.EmplArray.length + 1;
      if (!this.form.controls['done'].value) {
        this.selec.done = false
      }
      else {
        this.selec.done = true
      }
      this.selec.title = this.form.controls['title'].value;
      this.selec.descripcionT = this.form.controls['descripcionT'].value;
      this.selec.createdDate = this.toDay;
      this.selec.updatedDate = this.form.controls['updatedDate'].value;

      this.EmplArray.push(this.selec);
    }
    else {
      this.EmplArray.push(this.selec);
      this.EmplArray = this.EmplArray.filter(x => x != this.selec);

    }
    // limpiar input formulario
    this.selec = new Titulos();

  }


}
