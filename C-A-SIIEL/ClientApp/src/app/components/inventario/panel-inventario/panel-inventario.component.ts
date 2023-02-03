import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-panel-inventario',
  templateUrl: './panel-inventario.component.html',
  styleUrls: ['./panel-inventario.component.css']
})
export class PanelInventarioComponent  {
  arrOpciones: any[] = [{ id: 1, name: "Productos" }, { id: 2, name: "Servicios" }, { id: 3, name: "Combos" }, { id: 4, name: "Activos Prestador del Servicio" }];

  constructor(private router: Router) { }

  ngOnInit() {
  
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
}


