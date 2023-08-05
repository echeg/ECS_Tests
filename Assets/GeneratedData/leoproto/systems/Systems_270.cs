using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System270 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component105),typeof(Component201),typeof(Component129) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component446Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component446Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component284Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component284Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component179Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component179Pool.Get(_it.Entity());
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
  }
 }
}

}
