import { Component, Input } from '@angular/core';  //interfaz Input, permite pasar datos de un componente a otro

@Component({                               // utiliza Interfaz
  selector: 'app-message',                // como llamar el TAG
  templateUrl: './message.component.html' // archivo q representa contenido.
})
//export class MessageComponent {
//  @Input() texto: String;                // variable q recibe datos de entrada
//}
// cambia xxxxxxxx
export class MessageComponent {
  @Input() oMessage: Message;                // variable q recibe datos de entrada


  public Lista: string[] = ["1", "2", "3", "4", "5"];

}
interface Message {
  Id: number,
  Name: string,
  Message: string;
}
