using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System220 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component166),typeof(Component43) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component435Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component435Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component263Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component263Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component478Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component478Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component473Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component473Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
