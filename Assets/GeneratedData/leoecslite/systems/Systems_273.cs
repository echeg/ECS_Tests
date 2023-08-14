using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System273 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component258> _p1;
EcsPool<Component129> _p2;
EcsPool<Component484> _p3;
EcsPool<Component211> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component258>().Inc<Component129>().Inc<Component484>().End();
   _p1 = _world.GetPool<Component258>();
   _p2 = _world.GetPool<Component129>();
   _p3 = _world.GetPool<Component484>();
   _pl0 = _world.GetPool<Component211>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
