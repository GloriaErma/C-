import { Inject, Injectable } from '@angular/core';
import { Message } from '../Interfaz';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
//import { catchError } from 'rxjs/operator';

const httpOptions = {
  headers: new HttpHeaders({
    'Conten-Type': 'application/json',
    'Authorization': 'my-auth-token'
  })
}

@Injectable({ providedIn: 'root' })

// se inscribe en app.module.ts
export class ChatService {
  public algo: string = "Viene de chat.service.ts.algo de la class ChatService ";
  baseUrl: string;
  constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  public GetMessage(): Observable<Message[]>{
    //  NO en el contructor del componente db estar en servicio...
    //http.get<Message[]>(baseUrl + "api/Chat/Message").subscribe(result => {
    //  this.lstMsg = result;
    //}, error => console.error(error));
    //alert('chat.component.tes:::::::: + error   ');
    //console.log(Error);

    return this.http.get<Message[]>(this.baseUrl + "api/Chat/Message");
  }

  public Add(name, text) {
    this.http.post<Response>(this.baseUrl + 'api/Chat/Add', { 'Name': name, 'Text': text }, httpOptions)
        .subscribe(result => { console.log(result); },
                   error => console.error(error));
  }

}


