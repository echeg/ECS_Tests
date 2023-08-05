using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System184 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component492> _p1;
EcsPool<Component197> _p2;
EcsPool<Component436> _p3;
EcsPool<Component394> _p4;
EcsPool<Component153> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component492>().Inc<Component197>().Inc<Component436>().Inc<Component394>().End();
   _p1 = _world.GetPool<Component492>();
   _p2 = _world.GetPool<Component197>();
   _p3 = _world.GetPool<Component436>();
   _p4 = _world.GetPool<Component394>();
   _pl0 = _world.GetPool<Component153>();
 }
 public void Run (EcsSystems systems) {
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
