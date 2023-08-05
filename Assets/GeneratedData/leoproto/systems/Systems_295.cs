using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System295 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component181) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component61Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component61Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component115Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component115Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component215Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component215Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component116Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component116Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
