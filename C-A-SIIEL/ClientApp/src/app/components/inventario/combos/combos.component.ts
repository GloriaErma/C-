import { DatePipe } from '@angular/common';   //import date management GECS
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Titulos } from '../models/titulos';

import { Todo } from '../models/todo';

@Component({
  selector: 'app-combos',
  templateUrl: './combos.component.html',
  styleUrls: ['./combos.component.css']
})
export class CombosComponent implements OnInit {
  public toDay: Date = new Date();   //import date management GECS
  form!: FormGroup;
  formT!: FormGroup;

  NoVerFecha: boolean = false;
  //array: Todo[] = [];
  //array: string[] = ['p1', 'p2', 'p3'];
  title = 'objecttoToArray';
  dateString1 = new Date('1968-11-16T00:00:00');
  CombArray: Todo[] = [
    {
      id: 1,
      codBarras: 'Producto 9856',
      done: true, createdDate: this.dateString1, updatedDate: this.dateString1,
      nombre: 'COMBO Uno',
      descripcion: 'Descripcion COMBO Uno',
      bodega: 9856,
      seccion: 1234,
      pasillo: 2,
      estante: 2,
      grupo: 3,
      subGrupo: 3,
      clIpoConsumo: 3,
      clIva: 1,
      medida: 3,
      precio: 1,
      perenne: true,
      perecedero: false,
      perennePerecedero: 'Servicio 1234',
      fecVencto: '1965-09-12',
      invPropioConsignacion: 'propio',
      embalaje: 1,
      descuento: 1,
      garantia: 3,
      proveedor: 2,
      minimo: 3,
      maximo: 1,
      tiempoRotac: 2,
      preSugerido: 1,
    },
    {
      id: 2,
      codBarras: 'Producto 221',
      done: false, createdDate: this.dateString1, updatedDate: this.dateString1,
      nombre: 'COMBO Dos',
      descripcion: 'Descripcion COMBO Dos',
      bodega: 221,
      seccion: 13,
      pasillo: 2,
      estante: 2,
      grupo: 1,
      subGrupo: 2,
      clIpoConsumo: 1,
      clIva: 1,
      medida: 2,
      precio: 2,
      perenne: false,
      perecedero: true,
      perennePerecedero: 'Servicio 13',
      fecVencto: '1999-01-13',
      invPropioConsignacion: 'consignacion',
      embalaje: 3,
      descuento: 2,
      garantia: 2,
      proveedor: 2,
      minimo: 2,
      maximo: 2,
      tiempoRotac: 2,
      preSugerido: 2,
    },
  ]

  sel: Todo = new Todo();

  arrProductos: any[] = [{ id: 1, name: "Productos1" }, { id: 2, name: "Productos2" }, { id: 3, name: "Productos3" },
                         { id: 9856, name: "9856-Productos4" }, { id: 221, name: "221-Productos5" }, { id: 6, name: "Productos6" }];
  arrServicios: any[] = [{ id: 1, name: "Servicios1" }, { id: 2, name: "Servicios2" }, { id: 3, name: "Servicios3" },
                         { id: 1234, name: "1234-Servicios4" }, { id: 13, name: "13-Servicios5" }, { id: 6, name: "Servicios6" }];
  arrBodega: any[] = [{ id: 1, name: "opcion-1" }, { id: 2, name: "opcion-2" }, { id: 3, name: "opcion-3" }];

  arrGrupo:    any[] = [{ id: 1, name: "Grupo1" },  { id: 2, name: "Grupo2" }, { id: 3, name: "Grupo3" }];
  arrSubGrupo: any[] = [{ id: 1, name: "SubGrup1" }, { id: 2, name: "SubGrup2" }, { id: 3, name: "SubGrup3" }];


  constructor(private formBuilder: FormBuilder,
              private datePipe: DatePipe,
              private router: Router) { }

  ngOnInit() {
    this.toDay = new Date();   //import date management GECS
    console.log(this.datePipe.transform(this.toDay, "yyyy-MM-dd"));  //import date management GECS
    this.formT = this.formBuilder.group({
      nombre: [this.sel.nombre, Validators.required],
      descripcion: [this.sel.descripcion, Validators.required],
      codBarras: [this.sel.codBarras, Validators.required],
      bodega: [this.sel.bodega, Validators.required],
      seccion: [this.sel.seccion, Validators.required],
      pasillo: [this.sel.pasillo, Validators.required],
      estante: [this.sel.estante, Validators.required],
      grupo: [this.sel.grupo, Validators.required],
      subGrupo: [this.sel.subGrupo, Validators.required],
      clIpoConsumo: [this.sel.clIpoConsumo, Validators.required],
      clIva: [this.sel.clIpoConsumo, Validators.required],
      medida: [this.sel.medida, Validators.required],
      precio: [this.sel.precio, Validators.required],
      perennePerecedero: [this.sel.perennePerecedero, Validators.required],
      fecVencto: [this.sel.fecVencto, Validators.required],
      invPropioConsignacion: [this.sel.invPropioConsignacion, Validators.required],
      embalaje: [this.sel.embalaje, Validators.required],
      descuento: [this.sel.descuento, Validators.required],
      garantia: [this.sel.garantia, Validators.required],
      proveedor: [this.sel.proveedor, Validators.required],
      minimo: [this.sel.minimo, Validators.required],
      maximo: [this.sel.maximo, Validators.required],
      preSugerido: [this.sel.preSugerido, Validators.required],
      tiempoRotac: [this.sel.tiempoRotac, Validators.required],

    });
    /// incluir en arreglo bodega
  }

  openEditTodo(e: Todo) {
    this.sel = e;
    this.formT = this.formBuilder.group({
      nombre: [this.sel.nombre, Validators.required],
      descripcion: [this.sel.descripcion, Validators.required],
      codBarras: [this.sel.codBarras],
      createdDate: [this.sel.createdDate],
      updatedDate: [this.sel.updatedDate, Validators.required],
      bodega: [this.sel.bodega],
      seccion: [this.sel.seccion],
      pasillo: [this.sel.pasillo],
      estante: [this.sel.estante],
      grupo: [this.sel.grupo, Validators.required],
      subGrupo: [this.sel.subGrupo, Validators.required],
      clIpoConsumo: [this.sel.clIpoConsumo],
      clIva: [this.sel.clIva],
      medida: [this.sel.medida],
      precio: [this.sel.precio],
      perenne: [this.sel.perenne],
      perecedero: [this.sel.perecedero],
      perennePerecedero: [this.sel.perennePerecedero],
      fecVencto: [this.sel.fecVencto, Validators.required],
      invPropioConsignacion: [this.sel.invPropioConsignacion],
      embalaje: [this.sel.embalaje],
      descuento: [this.sel.descuento],
      garantia: [this.sel.garantia],
      proveedor: [this.sel.proveedor],
      minimo: [this.sel.minimo],
      maximo: [this.sel.maximo],
      preSugerido: [this.sel.preSugerido],
      tiempoRotac: [this.sel.tiempoRotac],
    });
  }

  
  AddEditTodo() {
    // NO hay empleado seleccionado == 0, es nuevo empleado
    if (this.sel.id === 0) {
      this.sel.id = this.CombArray.length + 1;
      if (!this.formT.controls['done'].value) {
        this.sel.done = false
      }
      else {
        this.sel.done = true
      }
      this.sel.nombre = this.formT.controls['nombre'].value,
        this.sel.descripcion = this.formT.controls['descripcion'].value
      this.sel.createdDate = this.toDay;
      this.sel.updatedDate = this.formT.controls['updatedDate'].value
      this.sel.bodega = this.formT.controls['bodega'].value,
        this.sel.seccion = this.formT.controls['seccion'].value,
        this.sel.pasillo = this.formT.controls['pasillo'].value,
        this.sel.estante = this.formT.controls['estante'].value,
        this.sel.grupo = this.formT.controls['grupo'].value,
        this.sel.subGrupo = this.formT.controls['subGrupo'].value,
        this.sel.clIpoConsumo = this.formT.controls['clIpoConsumo'].value,
        this.sel.clIva = this.formT.controls['clIva'].value,
        this.sel.medida = this.formT.controls['medida'].value,
        this.sel.precio = this.formT.controls['precio'].value,
        this.sel.perenne = this.formT.controls['perenne'].value,
        this.sel.perecedero = this.formT.controls['perecedero'].value,
        this.sel.fecVencto = this.formT.controls['fecVencto'].value,
        this.sel.invPropioConsignacion = this.formT.controls['invPropioConsignacion'].value,
        this.sel.embalaje = this.formT.controls['embalaje'].value,
        this.sel.descuento = this.formT.controls['descuento'].value,
        this.sel.garantia = this.formT.controls['garantia'].value,
        this.sel.proveedor = this.formT.controls['proveedor'].value,
        this.sel.minimo = this.formT.controls['minimo'].value,
        this.sel.maximo = this.formT.controls['maximo'].value,
        this.sel.preSugerido = this.formT.controls['preSugerido'].value,
        this.sel.tiempoRotac = this.formT.controls['tiempoRotac'].value,

        this.CombArray.push(this.sel);
    }
    else {
      this.CombArray.push(this.sel);
      this.CombArray = this.CombArray.filter(x => x != this.sel);

    }
    // limpiar input formulario
    this.sel = new Todo();

  }

  deleteTodo() {
    // El método filter te genera un nuevo array,
    // tomado del array principal, con los elementos que cumplan una condición.
    if (confirm("Are you sure you want to delete it?")) {
      this.CombArray = this.CombArray.filter(x => x != this.sel);
      this.sel = new Todo();
    }
  }

  public irServicios() {
    this.router.navigate(['/servicios']);
  }

  public irProductos() {
    this.router.navigate(['/productos']);
  }
}


