import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})



export class ServersComponent {
  serverId:number = 100;
  serverStatus:string = 'Offline';
  serverName : string = '';
  addNewServer:boolean=false;
  serverList = ['sql','oracle']

  ServerCreated:boolean = false;
  constructor(){
    setTimeout(()=>{
      this.addNewServer = true;
    },5000)
  }

  // onServerNameEntry(event:Event){
  //   this.serverName = (<HTMLInputElement>event.target).value
  //   // console.log(event.target);

  // }

  onServerCreation(){
      this.ServerCreated = true;
            this.serverList.push(this.serverName)

  }

  getServerId(){
    return this.serverId;
  }
  getServerStatus(){
    return this.serverStatus;
  }

}
