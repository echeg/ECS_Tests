using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System223 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component9),typeof(Component293),typeof(Component16),typeof(Component70) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component147Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component147Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component66Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component66Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component168Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component168Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component258Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component258Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
