using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System236 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component159> _p1;
EcsPool<Component231> _p2;
EcsPool<Component107> _p3;
EcsPool<Component418> _p4;
EcsPool<Component484> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component159>().Inc<Component231>().Inc<Component107>().Inc<Component418>().End();
   _p1 = _world.GetPool<Component159>();
   _p2 = _world.GetPool<Component231>();
   _p3 = _world.GetPool<Component107>();
   _p4 = _world.GetPool<Component418>();
   _pl0 = _world.GetPool<Component484>();
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
