import { HttpClient } from '@angular/common/http';
import { Component, Inject, ViewChild, ElementRef } from '@angular/core'; // importa CORE Angular
// formControl
import { FormControl } from '@angular/forms';

// Services
import { ChatService } from '../Service/chat.service';  //incluir servicio
// Interfaz
import { Message } from '../Interfaz'; // incluir Interfaz
// observable
import { Observable } from 'rxjs';
import { read } from 'fs';


@Component({                        // utiliza Interfaz
  selector: 'chat-app',              // como llamar el TAG
  templateUrl: "./chat.component.html"   // archivo q representa contenido.
})
//export class ChatComponent {         // inscrito en app.module.ts
//  public nombre = "GECS"

//  public CambiaNombre() {
//    this.nombre = "Nuevo"
//   }
//}

// decoradores experimentales
// botón derecho en el archivo -> Propiedades -> Acción de compilación: ninguna. Luego reinicie VS si es necesario.
//export class ChatComponent {         // inscrito en app.module.ts
//  public ListaMsg: string[] = ["Hola mundo", "Pepe", "Pica", "OtroElemento"];

//}
// cambio xxxxxxxxx
//export class ChatComponent {
//  public lstMsg: Message[];
  
//  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {
//    http.get<Message[]>(baseUrl + "api/Chat/Message").subscribe(result => {
//      this.lstMsg = result;
//    }, error => console.error(error));
//    alert('chat.component.tes:::::::: + error   ');
//    console.log(Error);
//  }
//}

// cambio xxxxxxxxx inscribir servicio
export class ChatComponent {

  public nombre = "GECS"
  public lstMsg: Observable<Message[]>;
  textControl = new FormControl('');
  nameControl = new FormControl('');
  @ViewChild('text')
    private _text: ElementRef;
    public get text(): ElementRef {
        return this._text;
    }
    public set text(value: ElementRef) {
        this._text = value;
    }

  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string,
    protected chatService: ChatService           //Inyección dependencia
  ) {
    //  NO en el contructor del componente db estar en servicio...
    //http.get<Message[]>(baseUrl + "api/Chat/Message").subscribe(result => {
    //  this.lstMsg = result;
    //}, error => console.error(error));
    //alert('chat.component.tes:::::::: + error   ');
    //console.log(Error);
    this.GetInfo();
  }
  public GetInfo() {
    this.lstMsg = this.chatService.GetMessage();
  }

  public CambiaNombre() {
    this.nombre = "Nuevo nombre GLORIA ERMA"
  }

  public Send() {
    this.chatService.Add(this.nameControl.value, this.textControl.value);
    setTimeout(() => {
      this.GetInfo();
    }, 300);


    this.textControl.setValue('');
    this.text.nativeElement.focus();

  }


}
// Interfaz va despues de export...
//  Se agrupa en un archivo Interfaz.ts
//interface Message {
//  Id: number,
//  Name: string,
//  Message: string;
//}
