using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System330 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component355),typeof(Component172),typeof(Component33),typeof(Component270) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component305Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component305Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component76Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component76Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component470Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component470Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component272Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component272Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
