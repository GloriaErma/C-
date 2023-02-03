import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'; // import that formGroup  GECS
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProductosComponent } from './components/inventario/productos/productos.component';
import { PanelInventarioComponent } from './components/inventario/panel-inventario/panel-inventario.component';
import { GetDemoComponent } from './components/inventario/get-demo/get-demo.component';
import { DatePipe } from '@angular/common';
import { ServiciosComponent } from './components/inventario/servicios/servicios.component';
import { CombosComponent } from './components/inventario/combos/combos.component';
import { ActivoServiciosComponent } from './components/inventario/activo-servicios/activo-servicios.component';
import { IngresoComponent } from './components/inventario/ingreso/ingreso.component';
import { SalidaComponent } from './components/inventario/salida/salida.component';
import { GruposComponent } from './components/parametrica/grupos/grupos.component';  //import date management GECS
//import { DlDateTimePickerModule, DlDateTimeDateModule } from 'angular-bootstrap-datetimepicker';
//import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
//import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProductosComponent,
    PanelInventarioComponent,
    GetDemoComponent,
    ServiciosComponent,
    CombosComponent,
    ActivoServiciosComponent,
    IngresoComponent,
    SalidaComponent,
    GruposComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,                  // import that formGroup  GECS
    ReactiveFormsModule,          // import that formGroup  GECS
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'panel-inventario', component: PanelInventarioComponent },  // ingresa ruta GECS
      { path: 'productos', component: ProductosComponent },  // ingresa ruta GECS
      { path: 'servicios', component: ServiciosComponent },  // ingresa ruta GECS
      { path: 'combos', component: CombosComponent },  // ingresa ruta GECS
      { path: 'grupos', component: GruposComponent },  // ingresa ruta GECS
    ]), 
  ],
  providers: [FormsModule, DatePipe],      // import that bootstrap-datetimepicker  GECS
                                           //import date management GECS
  bootstrap: [AppComponent],
  entryComponents: [PanelInventarioComponent]    //crear dinamicamente GECS
})
export class AppModule { }
