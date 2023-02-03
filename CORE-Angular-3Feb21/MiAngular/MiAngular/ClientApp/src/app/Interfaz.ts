// unifica interfaz
// definido export para poder ser utilizada en otro .ts

export interface Message {
  Id: number,
  Name: string,
  Message: string;
}

export interface Response {
  Success: number,
  Message: string,
  Data: any;                // public object Data { get; set; }
}
