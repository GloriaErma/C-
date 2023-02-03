import { Component } from '@angular/core';

@Component({
  //Nombre Componente como se invoca en HTML
  selector: 'app-nav-menu',
  //Nombre contenido HTML como se invoca
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
