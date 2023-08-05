using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System336 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component263),typeof(Component296),typeof(Component59),typeof(Component100) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component215Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component215Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component132Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component132Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component387Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component387Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component361Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component361Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
