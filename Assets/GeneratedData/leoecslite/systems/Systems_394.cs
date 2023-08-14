using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System394 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component4> _p1;
EcsPool<Component442> _p2;
EcsPool<Component437> _p3;
EcsPool<Component190> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component4>().Inc<Component442>().Inc<Component437>().End();
   _p1 = _world.GetPool<Component4>();
   _p2 = _world.GetPool<Component442>();
   _p3 = _world.GetPool<Component437>();
   _pl0 = _world.GetPool<Component190>();
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
