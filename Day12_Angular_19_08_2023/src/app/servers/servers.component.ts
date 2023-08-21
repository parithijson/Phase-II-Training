import { Component } from '@angular/core';
import { Observable } from 'rxjs';

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
  serverNumbers=[101,102,103]
  ServerCreated:boolean = false;
  constructor(){

    setTimeout(()=>{
      this.addNewServer = true;

    },5000);




  }

  // onServerNameEntry(event:Event){
  //   this.serverName = (<HTMLInputElement>event.target).value
  //   // console.log(event.target);

  // }

  getColor(){

      this.serverStatus = Math.random() > 0.5 ? 'Online' : 'Offline';

      return this.serverStatus == 'Online' ? 'green' : 'red';
  }

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
