using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System492 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component431> _p1;
EcsPool<Component30> _p2;
EcsPool<Component298> _p3;
EcsPool<Component138> _p4;
EcsPool<Component258> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component431>().Inc<Component30>().Inc<Component298>().Inc<Component138>().End();
   _p1 = _world.GetPool<Component431>();
   _p2 = _world.GetPool<Component30>();
   _p3 = _world.GetPool<Component298>();
   _p4 = _world.GetPool<Component138>();
   _pl0 = _world.GetPool<Component258>();
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
