export class Todo {
  id: number = 0;
  nombre!: string;
  descripcion!: string;
  codBarras!: string;
  grupo!: number;
  subGrupo!: number;
  done!: boolean;
  createdDate!: Date;
  updatedDate!: Date;
  bodega!: number;
  seccion!: number;
  pasillo!: number;
  estante!: number;
  clIpoConsumo!: number;
  clIva!: number;
  medida!: number;
  precio!: number;
  perenne!: boolean;
  perecedero!: boolean;
  fecVencto!: string;
  perennePerecedero!: string;
  invPropioConsignacion!: string;
  embalaje!: number;
  descuento!: number;
  garantia!: number;
  proveedor!: number;
  minimo!: number;
  maximo!: number;
  preSugerido!: number;
  tiempoRotac: number;


}
