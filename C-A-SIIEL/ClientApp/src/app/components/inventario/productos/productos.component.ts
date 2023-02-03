import { DatePipe } from '@angular/common';   //import date management GECS
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Titulos } from '../models/titulos';

import { Todo } from '../models/todo';

//FormsModule,                  // import that formGroup  GECS in app.module.ts
//ReactiveFormsModule,          // import that formGroup  GECS in app.module.ts

@Component({
  selector: 'app-productos',
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.css']
})
export class ProductosComponent implements OnInit {
  public toDay: Date = new Date();   //import date management GECS
  form!:  FormGroup;
  formT!: FormGroup;
  notFound: boolean = false;
  codigo!: Todo | null;
  nuevo: "00003"

  NoVerFecha: boolean = false;
  //array: Todo[] = [];
  //array: string[] = ['p1', 'p2', 'p3'];
  title = 'objecttoToArray';
  prod = {
    prod1: {
      codigo: 1,
      codigoBarra: 'barras p0',
      nombre: 'Producto Uno',
      descripcion: 'descripcion Producto Uno',
      Bodega: 1,
      Seccion: 2,
      pasillo: 2,
      estante: 8,
      grupo: 1,
      subGrupo: 3,
      ipoconsumo: 5,
      claseIva: 1,
      medida: 5,
      precio: 10,
      perenne: true,
      perecedero: false,
      fechaVence: '5/05/2021',
      inventarioPropio: true,
      inventarioConsigna: false,
      embalaje: "Caja",
      descuento: 0,
      garantia: 5,
      proveedor: 222,
      mínimos: 55,
      maximos: 5800,
      valorCompra: 500,
      precioSugerido: 555
    },
    prod2: {
      codigo: 2,
      nombre: 'Producto 2',
      descripcion: 'descripcion Producto 2',
      valorCompra: 100,
      precioSugerido: 155
    },
    prod3: {
      codigo: 3,
      nombre: 'Producto 3',
      descripcion: 'descripcion Producto 3',
      valorCompra: 5000,
      precioSugerido: 5550
    },
    prod4: {
      codigo: 4,
      nombre: 'Producto 4',
      descripcion: 'descripcion Producto 4',
      valorCompra: 4000,
      precioSugerido: 4550
    },
    prod5: {
      codigo: 5,
      nombre: 'Producto 5',
      descripcion: 'descripcion Producto 5',
      valorCompra: 200,
      precioSugerido: 255
    },
    prod6: {
      codigo: 6,
      nombre: 'Producto 6',
      descripcion: 'descripcion Producto 6',
      valorCompra: 3000,
      precioSugerido: 3550
    },
    prod7: {
      codigo: 7,
      nombre: 'Producto 7',
      descripcion: 'descripcion Producto 7',
      valorCompra: 4000,
      precioSugerido: 4550
    },

  };
  data = Object.values(this.prod);  // convertir data a arreglo, e we iterate over data
  dateString1 = new Date('1968-11-16T00:00:00');
  ProdArray: Todo[] = [
    {
      id: 1,
      codBarras: 'barras Producto Uno',
      done: true, createdDate: this.dateString1, updatedDate: this.dateString1,
      nombre: 'Producto Uno',
      descripcion: 'descripcion Producto Uno',
      bodega: 1,
      seccion: 2,
      pasillo: 2,
      estante: 2,
      grupo: 1,
      subGrupo: 2,
      clIpoConsumo: 3,
      clIva: 1,
      medida: 3,
      precio: 1,
      perenne: true,
      perecedero: false,
      perennePerecedero: 'perenne',
      fecVencto: '1965-09-12',
      invPropioConsignacion:  'propio',
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
      codBarras: 'barras Producto Dos',
      done: false, createdDate: this.dateString1, updatedDate: this.dateString1,
      nombre: 'Producto Dos',
      descripcion: 'descripcion Producto Dos',
      bodega: 1,
      seccion: 2,
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
      perennePerecedero: 'perecedero',
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
 
  ServArray: Todo[] = [
    {
      id: 1,
      codBarras: 'barras Servicio Uno',
      done: false, createdDate: this.dateString1, updatedDate: this.dateString1,
      nombre: 'Servicio Uno',
      descripcion: 'descripcion Servicio Uno',
      bodega: 1,
      seccion: 2,
      pasillo: 2,
      estante: 2,
      grupo: 1,
      subGrupo: 2,
      clIpoConsumo: 3,
      clIva: 1,
      medida: 3,
      precio: 1,
      perenne: true,
      perecedero: false,
      perennePerecedero: 'perenne',
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
      codBarras: 'barras Servicio Dos',
      done: false, createdDate: this.dateString1, updatedDate: this.dateString1,
      nombre: 'Servicio Dos',
      descripcion: 'descripcion Servicio Dos',
      bodega: 1,
      seccion: 2,
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
      perennePerecedero: 'perecedero',
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

  EmplArray: Titulos[] = [
    { id: 1, title: "Nombre1 Registro Tabla", descripcionT: "Descripción1 Regitro Tabla", done: true, createdDate: this.dateString1, updatedDate: "2000-01-11" },
    { id: 2, title: "Nombre2 Registro Tabla", descripcionT: "Descripción2 Regitro Tabla", done: true,  createdDate: this.dateString1, updatedDate: "2010-10-10" },
  ];
  selec: Titulos= new Titulos();

  arrGrupo: any[] = [{ id: 1, name: "Grupo1" },
  { id: 2, name: "Grupo2" },
  { id: 3, name: "Grupo3" }];
  arGrupo = {
    g1: { id: 1, name: "Grupo1" },
    g2: { id: 2, name: "Grupo2" },
    g3: { id: 3, name: "Grupo3" }
  };
  AGrupo = Object.values(this.arGrupo);
  //arrBodega: string[] = ["Bodega1", "Bodega2", "Bodeja3"];
  arrSubGrupo: any[] = [{ id: 1, name: "SubGrup1" }, { id: 2, name: "SubGrup2" }, { id: 3, name: "SubGrup3" }];
  arrBodega: any[] = [{ id: 1, name: "opcion-1" }, { id: 2, name: "opcion-2" }, { id: 3, name: "opcion-3" }];
  //arrSeccion: string[] = ["Seccion1", "Seccion2", "Seccion3"];
  arrSeccion: any[] = [{ id: 1, name: "Seccion1" }, { id: 2, name: "Seccion2" }, { id: 3, name: "Seccion3" }];
  //arrPasillo: string[] = ["Pasillo1", "Pasillo2", "Pasillo3"];
  arrPasillo: any[] = [{ id: 1, name: "Pasillo1" }, { id: 2, name: "Pasillo2" }, { id: 3, name: "Pasillo3" }];
  //arrEstante: string[] = ["Estante1", "Estante2", "Estante3"];
  arrEstante: any[] = [{ id: 1, name: "Estante1" }, { id: 2, name: "Estante2" }, { id: 3, name: "Estante3" }];
  //arrClIpoConsum: string[] = ["clIpoConsum1", "clIpoConsum2", "clIpoConsum3"];
  arrClIpoConsum: any[] = [{ id: 1, name: "ClIpoConsum1" }, { id: 2, name: "ClIpoConsum2" }, { id: 3, name: "ClIpoConsum3" }];
  //arrClIva: string[] = ["clIva1", "clIva2", "clIva3"];
  arrClIva: any[] = [{ id: 1, name: "ClIva1" }, { id: 2, name: "ClIva2" }, { id: 3, name: "ClIva3" }];
  //arrMedida: string[] = ["Medida1", "Medida2", "Medida3"];
  arrMedida: any[] = [{ id: 1, name: "Medida1" }, { id: 2, name: "Medida2" }, { id: 3, name: "Medida3" }];
  //arrVolumen: string[] = ["Volumen1", "Volumen2", "Volumen3"];
  arrPrecio: any[] = [{ id: 1, name: "Precio1" }, { id: 2, name: "Precio2" }, { id: 3, name: "Precio3" }];
  //arrEmbalaje: string[] = ["Embalaje1", "Embalaje2", "Embalaje3"];
  arrEmbalaje: any[] = [{ id: 1, name: "Embalaje1" }, { id: 2, name: "Embalaje2" }, { id: 3, name: "Embalaje3" }];
  //arrDescuento: string[] = ["Descuento1", "Descuento2", "Descuento3"];
  arrDescuento: any[] = [{ id: 1, name: "Descuento1" }, { id: 2, name: "Descuento2" }, { id: 3, name: "Descuento3" }];
  //arrGarantia: string[] = ["Garantia1", "Garantia2", "Garantia3"];
  arrGarantia: any[] = [{ id: 1, name: "Garantia1" }, { id: 2, name: "Garantia2" }, { id: 3, name: "Garantia3" }];
  //arrProveedor: string[] = ["Proveedor1", "Proveedor2", "Proveedor"];
  arrProveedor: any[] = [{ id: 1, name: "Proveedor1" }, { id: 2, name: "Proveedor2" }, { id: 3, name: "Proveedor3" }];
  //arrMinimo: string[] = ["Minimo1", "Minimo2", "Minimo3"];
  arrMinimo: any[] = [{ id: 1, name: "Minimo1" }, { id: 2, name: "Minimo2" }, { id: 3, name: "Minimo3" }];
  //arrMaximo: string[] = ["Maximo1", "Maximo2", "Maximo3"];
  arrMaximo: any[] = [{ id: 1, name: "Maximo1" }, { id: 2, name: "Maximo2" }, { id: 3, name: "Maximo3" }];
  //arrPreSugerido: string[] = ["PreSugerido1", "PreSugerido2", "PreSugerido3"];
  arrOpciones: any[] = [{ id: 1, name: "Productos" }, { id: 2, name: "Servicios" }, { id: 3, name: "Combos" }, { id: 4, name: "Activos Prrestador del Servicio" }];
  //arrTiempoRotac: string[] = ["TiempoRotac1", "TiempoRotac2", "TiempoRotac3"];
  arrTiempoRotac: any[] = [{ id: 1, name: "TiempoRotac1" }, { id: 2, name: "TiempoRotac2" }, { id: 3, name: "TiempoRotac3" }];
  //arrUnidMedida


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
  // SELECCION DE CADA REGISTRO DE CLASE
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

  AddEdit() {
    // NO hay empleado seleccionado == 0, es nuevo empleado
    if (this.selec.id === 0)
    {
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
    else
    {
      this.EmplArray.push(this.selec);
      this.EmplArray = this.EmplArray.filter(x => x != this.selec);
     
    }
    // limpiar input formulario
    this.selec = new Titulos();
  
  }

  AddEditTodo() {
    // NO hay empleado seleccionado == 0, es nuevo empleado
    if (this.sel.id === 0) {
      this.sel.id = this.ProdArray.length + 1;
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

      this.ProdArray.push(this.sel);
    }
    else {
      this.ProdArray.push(this.sel);
      this.ProdArray = this.ProdArray.filter(x => x != this.sel);

    }
    // limpiar input formulario
    this.sel = new Todo();

  }

  delete() {
    // El método filter te genera un nuevo array,
    // tomado del array principal, con los elementos que cumplan una condición.
    if (confirm("Are you sure you want to delete it?")) {
      this.EmplArray = this.EmplArray.filter(x => x != this.selec);
      this.selec = new Titulos();
    }
  }

  deleteTodo() {
    // El método filter te genera un nuevo array,
    // tomado del array principal, con los elementos que cumplan una condición.
    if (confirm("Are you sure you want to delete it?")) {
      this.ProdArray = this.ProdArray.filter(x => x != this.sel);
      this.sel = new Todo();
    }
  }

  public irTablas() {
    this.router.navigate(['/productos']);
  }
  public irProductos() {
    this.router.navigate(['/productos']);
  }
  public irServicios() {
    this.router.navigate(['/servicios']);
  }
  public irCombos() {
    this.router.navigate(['/combos']);
  }

  getUser(codigoId: string) {
    this.notFound = false;
    this.codigo = null;

    //this.codigoService.getUser(codigoId).subscribe((dataAPI: User) => { this.codigo = dataAPI; },
    //  (err: any) => { console.error(err); this.notFound = true });

  }
}
