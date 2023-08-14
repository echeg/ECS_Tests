using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System443 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component205> _p1;
EcsPool<Component104> _p2;
EcsPool<Component232> _p3;
EcsPool<Component105> _p4;
EcsPool<Component126> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component205>().Inc<Component104>().Inc<Component232>().Inc<Component105>().End();
   _p1 = _world.GetPool<Component205>();
   _p2 = _world.GetPool<Component104>();
   _p3 = _world.GetPool<Component232>();
   _p4 = _world.GetPool<Component105>();
   _pl0 = _world.GetPool<Component126>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
