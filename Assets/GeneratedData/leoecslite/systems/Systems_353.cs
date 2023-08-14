using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System353 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component107> _p1;
EcsPool<Component296> _p2;
EcsPool<Component66> _p3;
EcsPool<Component22> _p4;
EcsPool<Component223> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component107>().Inc<Component296>().Inc<Component66>().Inc<Component22>().End();
   _p1 = _world.GetPool<Component107>();
   _p2 = _world.GetPool<Component296>();
   _p3 = _world.GetPool<Component66>();
   _p4 = _world.GetPool<Component22>();
   _pl0 = _world.GetPool<Component223>();
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
