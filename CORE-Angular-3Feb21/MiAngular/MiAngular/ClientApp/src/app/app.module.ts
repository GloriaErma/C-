import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';  // Can't bind to 'formControl' since it isn't a known property of 'input'
import { HttpClientModule } from '@angular/common/http';  // peticiones HTTP
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ChatComponent } from './Chat/chat.component';  //incluir componente
import { MessageComponent } from './Message/message.component';  //incluir componente
import { MsgComponent } from './Msg/Msg.component';  //incluir componente

// Services
import { ChatService } from './Service/chat.service';  //incluir servicio


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ChatComponent,                //incluir componente
    MessageComponent,                //incluir componente
    MsgComponent                  //incluir componente

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,          //incluir Module X Can't bind to 'formControl' since it isn't a known property of 'input'
    //Configuraciön Rutas
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'chat', component: ChatComponent }  //incluir componente
    ])
  ],
  providers: [ChatService],   //incluir servicio
  bootstrap: [AppComponent]
})
export class AppModule { }
