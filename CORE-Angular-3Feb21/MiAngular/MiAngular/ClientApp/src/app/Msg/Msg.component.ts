import { Component, Input} from "@angular/core";  //enviar datos de un componente a otro GECS


@Component({
  selector: 'app-msg',
  //template: '<div> vengo de Msg.component</div>'
  template: '<div>  {{ entrada  }}  </div>'
})

export class MsgComponent {
  @Input() entrada: string;            //enviar datos de un componente a otro GECS

}
