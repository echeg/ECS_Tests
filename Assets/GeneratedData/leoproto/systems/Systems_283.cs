using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System283 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component294),typeof(Component426),typeof(Component20),typeof(Component425) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component306Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component306Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component269Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component269Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component496Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component496Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component346Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component346Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
