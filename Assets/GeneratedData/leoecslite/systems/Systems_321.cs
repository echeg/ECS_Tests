using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System321 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component199> _p1;
EcsPool<Component482> _p2;
EcsPool<Component43> _p3;
EcsPool<Component49> _p4;
EcsPool<Component215> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component199>().Inc<Component482>().Inc<Component43>().Inc<Component49>().End();
   _p1 = _world.GetPool<Component199>();
   _p2 = _world.GetPool<Component482>();
   _p3 = _world.GetPool<Component43>();
   _p4 = _world.GetPool<Component49>();
   _pl0 = _world.GetPool<Component215>();
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
